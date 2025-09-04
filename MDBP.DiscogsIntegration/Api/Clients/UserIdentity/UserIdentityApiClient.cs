using System.Text.Json;
using MusicDBPlayground.DiscogsIntegration.Api.ApiModels;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients.UserIdentity;

public class UserIdentityApiClient(HttpClient httpClient, DiscogsOAuthClient oAuthClient) : IDiscogsUserIdentityApi
{
    private HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    private DiscogsOAuthClient _oAuthClient = oAuthClient ?? throw new ArgumentNullException(nameof(oAuthClient));


    public async Task<ApiModels.UserIdentity?> GetUserIdentityAsync(CancellationToken cancellationToken = default)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "/oauth/identity");
        
        _oAuthClient.SignRequest(request);
        
        var response = await _httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();
        
        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        var identity = await JsonSerializer.DeserializeAsync<ApiModels.UserIdentity>(stream, cancellationToken: cancellationToken);
        
        return identity;
    }

    public Task<UserProfile?> GetUserProfileAsync(string username, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UserProfileUpdateResponse?> UpdateUserProfileAsync(string username, string? name, string? homepage, string? location, string? profileInfo,
        string? currAbbr, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UserSubmissionsResponse?> GetUserSubmissionsAsync(string username, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UserContributionsResponse?> GetUserContributionsAsync(string username, string? sort, string? sortOrder,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}