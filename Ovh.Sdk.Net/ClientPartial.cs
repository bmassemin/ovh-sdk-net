using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ovh.Sdk.Net;

public partial class Client
{
    private readonly string _applicationSecret;
    private readonly HttpClient _client;
    private readonly string _consumerKey;
    private readonly TimeSpan _delta;

    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new JsonStringEnumConverter() }
    };

    public Client(HttpClient client, string applicationKey, string applicationSecret, string consumerKey)
    {
        _client = client;
        _client.DefaultRequestHeaders.Add("X-Ovh-Application", applicationKey);

        _applicationSecret = applicationSecret;
        _consumerKey = consumerKey;

        _delta = TimeSpan.FromSeconds(_client.GetFromJsonAsync<long>(new Uri("/v1/auth/time", UriKind.Relative)).Result - DateTimeOffset.UtcNow.ToUnixTimeSeconds());
    }

    private string CreateQueryParams(Dictionary<string, object> parameters)
    {
        if (parameters.Values.All(x => x == null))
            return string.Empty;

        var values = parameters
            .Where(x => x.Value != null)
            .ToDictionary(x => x.Key, x => JsonSerializer.Serialize(x, _options));
        return "?" + new FormUrlEncodedContent(values).ReadAsStringAsync().Result;
    }

    private async Task<T> SendAsync<T>(string method, string path, object? data, bool needAuth)
    {
        var response = await SendAsync(method, path, data, needAuth);
        return (await response.Content.ReadFromJsonAsync<T>(_options))!;
    }

    private async Task<HttpResponseMessage> SendAsync(string method, string path, object? data, bool needAuth)
    {
        var request = new HttpRequestMessage(HttpMethod.Parse(method), path);
        var dataStr = string.Empty;
        if (data != null)
        {
            dataStr = JsonSerializer.Serialize(data, _options);
            request.Content = new StringContent(dataStr, Encoding.UTF8, "application/json");
        }

        if (needAuth) SetAuth(request, method, path, dataStr);

        var response = await _client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        return response;
    }

    private void SetAuth(HttpRequestMessage request, string method, string target, string data)
    {
        var timestamp = DateTimeOffset.UtcNow.Add(_delta).ToUnixTimeSeconds();
        var signature = ComputeSignature(timestamp, method, new Uri(_client.BaseAddress!, target).ToString(), data);

        request.Headers.Add("X-Ovh-Consumer", _consumerKey);
        request.Headers.Add("X-Ovh-Timestamp", timestamp.ToString());
        request.Headers.Add("X-Ovh-Signature", signature);
    }

    public string ComputeSignature(long currentTimestamp, string method, string target, string? data = null)
    {
        var sha1 = SHA1.Create();
        var toSign = string.Join("+", _applicationSecret, _consumerKey, method, target, data, currentTimestamp);
        var binaryHash = sha1.ComputeHash(Encoding.UTF8.GetBytes(toSign));
        var signature = string.Join("", binaryHash.Select(x => x.ToString("X2"))).ToLower();
        return $"$1${signature}";
    }
}