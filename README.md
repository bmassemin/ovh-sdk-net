# ovh sdk .net
This repository provides a client to interact with the OVH API. However, please note that OVH already provides an official OpenAPI 3 specification for their API, so you can skip any manual generation of specs and directly leverage this in your tooling!

## Official OpenAPI Spec:
You can find the official OVH OpenAPI 3 specification here:
[OVH API OpenAPI 3 Spec](https://eu.api.ovh.com/1.0/cloud.json?format=openapi3)

You can use this OpenAPI spec with any OpenAPI-compatible tools to generate clients for various programming languages, or just explore the API documentation more easily.

## How to use

```csharp
using Ovh.Sdk.Net;

var client = new Client(new HttpClient
{
    BaseAddress = new Uri("https://eu.api.ovh.com"),
}, <applicationKey>, <applicationSecret>, <consumerKey>);

var projects = await client.GetV1CloudProjectAsync();
foreach (var project in projects)
{
    var projectInfo = await client.GetV1CloudProjectServiceNameAsync(project);
}
```
