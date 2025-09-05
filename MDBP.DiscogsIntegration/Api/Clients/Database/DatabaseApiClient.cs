using MusicDBPlayground.DiscogsIntegration.Clients;
using System.Text.Json;
using System.Text.Json.Serialization;
using MusicDBPlayground.DiscogsIntegration.Api.ApiModels;
using MusicDBPlayground.DiscogsIntegration.Services;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients.Database;

public class DatabaseApiClient(HttpService httpService) : IDiscogsDatabaseApi
{
    private readonly HttpService _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
    public async Task<Release?> GetReleaseAsync(int releaseId, string? currAbbr = null, CancellationToken cancellationToken = default)
    {
        var path = $"/releases/{releaseId}";
        if (!string.IsNullOrEmpty(currAbbr))
            path += $"?curr_abbr={currAbbr}";

        return await _httpService.GetAndDeserializeAsync<Release?>(path, cancellationToken);
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