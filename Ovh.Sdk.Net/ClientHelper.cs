using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ovh.Sdk.Net
{
    internal static class ClientHelper
    {
        public static string CreateQueryParams(Dictionary<string, object> parameters)
        {
            if (parameters.Values.All(x => x == null))
                return string.Empty;

            var values = parameters
                .Where(x => x.Value != null)
                .ToDictionary(x => x.Key, x => JsonSerializer.Serialize(x));
            return new FormUrlEncodedContent(values).ReadAsStringAsync().Result;
        }
    }
}