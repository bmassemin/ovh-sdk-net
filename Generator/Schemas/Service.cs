using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Schemas
{
    public class Service(Client client)
    {
        public async Task<List<ApiList>> GetApiDefinitionsAsync(string version)
        {
            var apis = await client.GetApiListAsync(version);
            var result = new List<ApiList>();
            foreach (var api in apis.Apis)
            {
                if (!api.Format.Contains(Format.Json))
                    throw new NotSupportedException("Only JSON format is supported");

                var list = await client.GetApiAsync(version, api.Path, Format.Json);
                result.Add(list);
            }

            return result;
        }
    }
}