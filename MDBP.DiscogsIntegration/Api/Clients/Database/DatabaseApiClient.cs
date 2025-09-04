using MusicDBPlayground.DiscogsIntegration.Clients;
using System.Text.Json;
using System.Text.Json.Serialization;
using MusicDBPlayground.DiscogsIntegration.Api.ApiModels;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients.Database;

public class DatabaseApiClient(HttpClient httpClient, DiscogsOAuthClient oAuthClient) : IDiscogsDatabaseApi
{
    private HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    private DiscogsOAuthClient _oAuthClient = oAuthClient ?? throw new ArgumentNullException(nameof(oAuthClient)); 
    
    
    public async Task<Release?> GetReleaseAsync(int releaseId, string? currAbbr = null, CancellationToken cancellationToken = default)
    {
        var path = $"/releases/{releaseId}";
        if (!string.IsNullOrEmpty(currAbbr))
            path += $"?curr_abbr={currAbbr}";
        
        var request = new HttpRequestMessage(HttpMethod.Get, path);
        _oAuthClient.SignRequest(request);
        
        var response = await _httpClient.SendAsync(request, cancellationToken);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        var release = await JsonSerializer.DeserializeAsync<Release>(stream, cancellationToken: cancellationToken);

        return release; 
    }

    public Task<ReleaseStats?> GetReleaseStatsAsync(int releaseId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReleaseUserRating?> GetReleaseUserRatingAsync(int releaseId, string username, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReleaseUserRating?> SetReleaseUserRatingAsync(int releaseId, string username, int rating,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteReleaseUserRatingAsync(int releaseId, string username, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ReleaseCommunityRating?> GetReleaseCommunityRatingAsync(int releaseId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MasterRelease?> GetMasterReleaseAsync(int masterId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<MasterReleaseVersionsResponse> GetMasterReleaseVersionsAsync(int masterId, int? page = null, int? perPage = null, string? format = null,
        string? label = null, string? released = null, string? country = null, string? sort = null,
        string? sortOrder = null, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<Artist?> GetArtistAsync(int artistId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<ArtistReleasesResponse?> GetArtistReleasesAsync(int artistId, string? sort, string? sortOrder,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Label?> GetLabelAsync(int labelId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<LabelReleasesResponse> GetLabelReleasesAsync(int labelId, int? page = null, int? perPage = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<SearchResponse> SearchAsync(SearchRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}