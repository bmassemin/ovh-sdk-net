using _iam_policy;
using _oauth2;
using Ovh.Sdk.Net;
using Ovh.Sdk.Net.AuthProviders;
using Action = _iam_policy.Action;

// Login with an application

// Fetch credentials from environment variables (OVH_APPLICATION_KEY, OVH_APPLICATION_SECRET, OVH_CONSUMER_KEY)
var applicationProvider = new Application();

// Uncomment this line to log all requests and responses
//var handler = new LogHandler(new HttpClientHandler());
var handler = new HttpClientHandler();

var adminClient = new Client(new HttpClient(handler)
{
    BaseAddress = new Uri("https://eu.api.ovh.com"),
}, applicationProvider);

// Create a service account

var serviceAccount = await adminClient.PostV1MeApiOauth2ClientAsync(new clientRequest
{
    Name = "ProjectViewer",
    Description = "Service account to view all projects",
    CallbackUrls = [],
    Flow = ClientFlowEnum.CLIENT_CREDENTIALS,
});
var saInfos = await adminClient.GetV1MeApiOauth2ClientClientIdAsync(serviceAccount.ClientId);

// Upsert the policy for the service account

var activePolicies = await adminClient.GetV2IamPolicyAsync();
var policy = activePolicies.FirstOrDefault(x => x.Name == "OvhSdkNet_Sample");
if (policy == null)
{
    policy = await adminClient.PostV2IamPolicyAsync(new Creation
    {
        Description = "View all projects",
        Identities = [saInfos.Identity],
        Name = "OvhSdkNet_Sample",
        Permissions = new Permissions
        {
            Allow =
            [
                new Action
                {
                    _Action = "publicCloudProject:apiovh:get"
                }
            ]
        },
        Resources = [new Resource { Urn = "urn:v1:eu:resource:publicCloudProject:*" }]
    });
}
else
{
    await adminClient.PutV2IamPolicyPolicyIdAsync(new Update
    {
        Description = "View all projects",
        Identities = [saInfos.Identity],
        Name = "OvhSdkNet_Sample",
        Permissions = new Permissions
        {
            Allow =
            [
                new Action
                {
                    _Action = "publicCloudProject:apiovh:get"
                }
            ]
        },
        Resources = [new Resource { Urn = "urn:v1:eu:resource:publicCloudProject:*" }]
    }, policy.Id);
}

// Login with the service account

var oauthProvider = new OAuth2(serviceAccount.ClientId, serviceAccount._ClientSecret, "https://www.ovh.com/auth/oauth2/token");

var serviceAccountClient = new Client(new HttpClient(handler)
{
    BaseAddress = new Uri("https://eu.api.ovh.com"),
}, oauthProvider);

// Get all projects with our new service account

var projects = await serviceAccountClient.GetV1CloudProjectAsync();
foreach (var project in projects)
{
    var projectInfo = await serviceAccountClient.GetV1CloudProjectServiceNameAsync(project);
    Console.WriteLine($"{project}: {projectInfo.Description}");
}

// Cleanup the service account and policy

await adminClient.DeleteV2IamPolicyPolicyIdAsync(policy.Id);
await adminClient.DeleteV1MeApiOauth2ClientClientIdAsync(serviceAccount.ClientId);