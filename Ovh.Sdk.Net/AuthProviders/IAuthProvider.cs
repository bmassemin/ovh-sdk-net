using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovh.Sdk.Net.AuthProviders
{
    public interface IAuthProvider
    {
        void SetupHttpClient(HttpClient client);
        void SetAuth(HttpRequestMessage request, string method, string path, string data);
    }
}