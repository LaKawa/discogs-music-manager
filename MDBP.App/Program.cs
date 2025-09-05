// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using MusicDBPlayground.DiscogsIntegration;
using MusicDBPlayground.DiscogsIntegration.Security;

Console.WriteLine("Hello, World!");
using var client = new HttpClient();
var discogsClient = new DiscogsClient(client);
await discogsClient.AuthenticateAsync();

var identity = await discogsClient.UserIdentity.GetUserIdentityAsync();
Console.WriteLine(identity);
Console.ReadLine();

var release = await discogsClient.Database.GetReleaseAsync(2);
var json = JsonSerializer.Serialize(release, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(json);

var folders = await discogsClient.UserCollection.GetUserCollectionFoldersAsync("LaKawa");
var json2 = JsonSerializer.Serialize(folders, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(json2);




Console.ReadLine();
Console.WriteLine("Done!");