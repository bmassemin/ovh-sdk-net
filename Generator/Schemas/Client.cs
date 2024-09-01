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

        public Task<ApiGroups> GetApiListAsync()
        {
            return httpClient.GetFromJsonAsync<ApiGroups>("1.0", _options)!;
        }

        public Task<ApiList> GetApiAsync(string path, Format format)
        {
            return httpClient.GetFromJsonAsync<ApiList>($"1.0{path}.{format.ToString().ToLower()}")!;
        }
    }
}