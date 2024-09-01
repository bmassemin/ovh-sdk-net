using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ovh.Sdk.Net.Sample
{
    class LogHandler : DelegatingHandler
    {
        private readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters = { new JsonStringEnumConverter() }
        };

        public LogHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var bodyOutLog = "void";
            if (request.Content != null)
            {
                bodyOutLog = await request.Content.ReadAsStringAsync(cancellationToken);
                try
                {
                    var tempJson = JsonSerializer.Deserialize<JsonElement>(bodyOutLog);
                    bodyOutLog = JsonSerializer.Serialize(tempJson, _jsonSerializerOptions);
                }
                catch
                {
                    // ignored
                }
            }

            Console.WriteLine($"[OVH] => {request.Method} {request.RequestUri}:\n{bodyOutLog}");
            var response = await base.SendAsync(request, cancellationToken);

            string bodyInLog = "void";
            try
            {
                var tempStr = await response.Content.ReadAsStringAsync(cancellationToken);
                var tempJson = JsonSerializer.Deserialize<JsonElement>(tempStr);
                bodyInLog = JsonSerializer.Serialize(tempJson, _jsonSerializerOptions);
            }
            catch
            {
                // ignored
            }


            Console.WriteLine($"[OVH] <= {response.StatusCode}:\n{bodyInLog}");
            return response;
        }
    }
}