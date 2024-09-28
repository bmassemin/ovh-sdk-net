using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ovh.Sdk.Net.AuthProviders
{
    public class Application : IAuthProvider
    {
        private readonly string _applicationKey;
        private readonly string _applicationSecret;
        private readonly string _consumerKey;
        private TimeSpan _delta;
        private HttpClient _client;

        public Application(string applicationKey, string applicationSecret, string consumerKey)
        {
            _applicationKey = applicationKey;
            _applicationSecret = applicationSecret;
            _consumerKey = consumerKey;
        }

        public void SetupHttpClient(HttpClient client)
        {
            _client = client;
            client.DefaultRequestHeaders.Add("X-Ovh-Application", _applicationKey);
            _delta = TimeSpan.FromSeconds(client.GetFromJsonAsync<long>(new Uri("/v1/auth/time", UriKind.Relative)).Result - DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        }

        public void SetAuth(HttpRequestMessage request, string method, string target, string data)
        {
            var timestamp = DateTimeOffset.UtcNow.Add(_delta).ToUnixTimeSeconds();
            var signature = ComputeSignature(timestamp, method, new Uri(_client.BaseAddress!, target).ToString(), data);

            request.Headers.Add("X-Ovh-Consumer", _consumerKey);
            request.Headers.Add("X-Ovh-Timestamp", timestamp.ToString());
            request.Headers.Add("X-Ovh-Signature", signature);
        }

        private string ComputeSignature(long currentTimestamp, string method, string target, string? data = null)
        {
            var sha1 = SHA1.Create();
            var toSign = string.Join("+", _applicationSecret, _consumerKey, method, target, data, currentTimestamp);
            var binaryHash = sha1.ComputeHash(Encoding.UTF8.GetBytes(toSign));
            var signature = string.Join("", binaryHash.Select(x => x.ToString("X2"))).ToLower();
            return $"$1${signature}";
        }
    }
}