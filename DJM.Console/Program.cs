// See https://aka.ms/new-console-template for more information

using DJM.DiscogsIntegration;
using DJM.DiscogsIntegration.Security;

Console.WriteLine("Hello, World!");
using var client = new HttpClient();
var discogsClient = new DiscogsClient(client);
await discogsClient.AuthenticateAsync();

var identity = await discogsClient.GetUserIdentityAsync();
Console.WriteLine(identity);

Console.ReadLine();
Console.WriteLine("Done!");