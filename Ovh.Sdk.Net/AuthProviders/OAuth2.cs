using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Ovh.Sdk.Net.AuthProviders
{
    public class OAuth2AccessToken
    {
        [JsonPropertyName("access_token")] public string AccessToken { get; set; }
        [JsonPropertyName("token_type")] public string TokenType { get; set; }
        [JsonPropertyName("expires_in")] public int ExpiresIn { get; set; }
        [JsonPropertyName("scope")] public string Scope { get; set; }
    }

    public class OAuth2 : IAuthProvider
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _endpoint;
        private HttpClient _client;
        private OAuth2AccessToken _token;
        private DateTime _expirationDate;

        public OAuth2(string clientId, string clientSecret, string endpoint)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
            _endpoint = endpoint;
        }

        public void SetupHttpClient(HttpClient client)
        {
            _client = client;
            _token = GetOAuth2Token(_clientId, _clientSecret).Result;
            _expirationDate = DateTime.UtcNow.AddSeconds(_token.ExpiresIn);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token.AccessToken);
        }

        public void SetAuth(HttpRequestMessage request, string method, string path, string data)
        {
            if (DateTime.UtcNow >= _expirationDate.AddMinutes(-1))
            {
                SetupHttpClient(_client);
            }

            request.Headers.Add("Authorization", "Bearer " + _token.AccessToken);
        }

        private async Task<OAuth2AccessToken> GetOAuth2Token(string clientId, string clientSecret)
        {
            var response = await _client.PostAsync(_endpoint, new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials",
                ["client_id"] = clientId,
                ["client_secret"] = clientSecret,
                ["scope"] = "all"
            }));
            response.EnsureSuccessStatusCode();
            return (await response.Content.ReadFromJsonAsync<OAuth2AccessToken>())!;
        }
    }
}