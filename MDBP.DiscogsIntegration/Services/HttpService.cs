using System.Text.Json;
using MusicDBPlayground.DiscogsIntegration.Api.Clients;

namespace MusicDBPlayground.DiscogsIntegration.Services;

public class HttpService(HttpClient httpClient, DiscogsOAuthClient oAuthClient)
{
    private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    private readonly DiscogsOAuthClient _oAuthClient = oAuthClient ?? throw new ArgumentNullException(nameof(oAuthClient));

    public async Task<T?> SendGetAsync<T>(string path, CancellationToken cancellationToken = default)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, path);
        _oAuthClient.SignRequest(request);

        var response = await _httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        return await JsonSerializer.DeserializeAsync<T>(stream, cancellationToken: cancellationToken);
    }
}