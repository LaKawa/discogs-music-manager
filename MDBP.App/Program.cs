// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using MusicDBPlayground.DiscogsIntegration;
using MusicDBPlayground.DiscogsIntegration.Security;

Console.WriteLine("Hello, World!");
using var client = new HttpClient();
var discogsClient = new DiscogsClient(client);
await discogsClient.AuthenticateAsync();

var identity = await discogsClient.GetUserIdentityAsync();
var release = await discogsClient.GetReleaseAsync(2);
Console.WriteLine(identity);
Console.WriteLine(release);

var json = JsonSerializer.Serialize(release, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(json);


Console.ReadLine();
Console.WriteLine("Done!");