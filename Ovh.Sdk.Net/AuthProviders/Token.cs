namespace Ovh.Sdk.Net.AuthProviders
{
    public class Token(string token) : IAuthProvider
    {
        public void SetupHttpClient(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        }

        public void SetAuth(HttpRequestMessage request, string method, string path, string data)
        {
        }
    }
}