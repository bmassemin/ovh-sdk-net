using Ovh.Sdk.Net;

var client = new Client(new HttpClient());
await client.GetAllDomAsync();