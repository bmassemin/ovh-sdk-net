namespace Ovh.Sdk.Net.AuthProviders
{
    public class Token : IAuthProvider
    {
        private readonly string _token;

        public Token()
        {
            _token = Environment.GetEnvironmentVariable("OVH_ACCESS_TOKEN") ?? throw new InvalidOperationException();
        }

        public Token(string token)
        {
            _token = token;
        }

        public void SetupHttpClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token);
        }

        public void SetAuth(HttpRequestMessage request, string method, string path, string data)
        {
        }
    }
}