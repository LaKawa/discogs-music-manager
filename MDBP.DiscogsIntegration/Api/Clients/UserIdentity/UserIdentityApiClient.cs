using System.Text.Json;
using MusicDBPlayground.DiscogsIntegration.Api.ApiModels;
using MusicDBPlayground.DiscogsIntegration.Services;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients.UserIdentity;

public class UserIdentityApiClient(HttpService httpService) : IDiscogsUserIdentityApi
{
    private readonly HttpService _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));

    public async Task<ApiModels.UserIdentity?> GetUserIdentityAsync(CancellationToken cancellationToken = default)
    {
        const string path = "/oauth/identity";
        return await _httpService.SendGetAsync<ApiModels.UserIdentity?>(path, cancellationToken);
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