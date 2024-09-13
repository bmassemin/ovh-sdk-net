using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Generator.Schemas
{
    public class Client(HttpClient httpClient)
    {
        private readonly JsonSerializerOptions _options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter() }
        };

        public Task<ApiGroups> GetApiListAsync(string version)
        {
            return httpClient.GetFromJsonAsync<ApiGroups>(version, _options)!;
        }

        public Task<ApiList> GetApiAsync(string version, string path, Format format)
        {
            return httpClient.GetFromJsonAsync<ApiList>($"{version}{path}.{format.ToString().ToLower()}")!;
        }
    }
}