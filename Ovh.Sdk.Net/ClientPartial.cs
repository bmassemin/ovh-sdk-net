using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Ovh.Sdk.Net.AuthProviders;

namespace Ovh.Sdk.Net;

public partial class Client
{
    private readonly HttpClient _client;
    private readonly IAuthProvider _authProvider;

    private readonly JsonSerializerOptions _options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new JsonStringEnumConverter() }
    };

    public Client(HttpClient client, IAuthProvider authProvider)
    {
        _client = client;
        _authProvider = authProvider;
        _authProvider.SetupHttpClient(client);
    }

    private string CreateQueryParams(Dictionary<string, object> parameters)
    {
        if (parameters.Values.All(x => x == null))
            return string.Empty;

        var values = new List<KeyValuePair<string, string>>();
        foreach (var parameter in parameters)
        {
            if (parameter.Value == null)
                continue;
            var valuesAsString = SerializeQueryParamValue(parameter.Value);
            foreach (var value in valuesAsString)
                values.Add(new KeyValuePair<string, string>(parameter.Key, value));
        }

        return "?" + new FormUrlEncodedContent(values).ReadAsStringAsync().Result;
    }

    private string[] SerializeQueryParamValue(object obj)
    {
        if (IsSimpleType(obj.GetType()))
            return [obj.ToString()];
        if (obj.GetType().IsArray)
            return ((Array)obj).Cast<object>().SelectMany(SerializeQueryParamValue).ToArray();
        return [JsonSerializer.Serialize(obj, _options)];
    }

    private bool IsSimpleType(Type type)
    {
        return
            type.IsValueType ||
            type.IsPrimitive ||
            new[]
            {
                typeof(string),
                typeof(Decimal),
                typeof(DateTime),
                typeof(DateTimeOffset),
                typeof(TimeSpan),
                typeof(Guid)
            }.Contains(type) ||
            Convert.GetTypeCode(type) != TypeCode.Object;
    }

    private Dictionary<string, string> CreateHeaders(Dictionary<string, object> parameters)
    {
        if (parameters.Values.All(x => x == null))
            return null;

        var headers = new Dictionary<string, string>();
        foreach (var parameter in parameters)
        {
            if (parameter.Value == null)
                continue;
            headers.Add(parameter.Key, parameter.Value.ToString());
        }

        return headers;
    }

    private async Task<T> SendAsync<T>(string method, string path, Dictionary<string, string>? headers, object? data, bool needAuth)
    {
        var response = await SendAsync(method, path, headers, data, needAuth);
        return (await response.Content.ReadFromJsonAsync<T>(_options))!;
    }

    private async Task<HttpResponseMessage> SendAsync(string method, string path, Dictionary<string, string>? headers, object? data, bool needAuth)
    {
        var request = new HttpRequestMessage(HttpMethod.Parse(method), path);
        var dataStr = string.Empty;
        if (data != null)
        {
            dataStr = JsonSerializer.Serialize(data, _options);
            request.Content = new StringContent(dataStr, Encoding.UTF8, "application/json");
        }

        if (headers != null)
        {
            foreach (var (key, value) in headers)
                request.Headers.Add(key, value);
        }

        if (needAuth) _authProvider.SetAuth(request, method, path, dataStr);

        var response = await _client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        return response;
    }
}