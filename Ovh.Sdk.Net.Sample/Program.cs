using Ovh.Sdk.Net;
using Ovh.Sdk.Net.Sample;

var client = new Client(new HttpClient(new LogHandler(new HttpClientHandler()))
{
    BaseAddress = new Uri("https://eu.api.ovh.com"),
}, "", "", "");

var projects = await client.GetV1CloudProjectAsync();
foreach (var project in projects)
{
    var projectInfo = await client.GetV1CloudProjectServiceNameAsync(project);
}