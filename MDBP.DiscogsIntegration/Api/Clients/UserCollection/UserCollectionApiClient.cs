using MusicDBPlayground.DiscogsIntegration.Api.ApiModels;
using MusicDBPlayground.DiscogsIntegration.Clients;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients.UserCollection;

public class UserCollectionApiClient(HttpClient httpClient, DiscogsOAuthClient oAuthClient) : IDiscogsUserCollectionApi
{
    private HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    private DiscogsOAuthClient _oAuthClient = oAuthClient ?? throw new ArgumentNullException(nameof(oAuthClient));
    public Task<UserCollectionFolders?> GetUserCollectionFoldersAsync(string username, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionFolder?> CreateUserCollectionFolderAsync(string username, string? folderName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionFolder?> GetUserCollectionFolderAsync(string username, int folderId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionFolder?> UpdateUserCollectionFolderAsync(string username, int folderId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserCollectionFolderAsync(string username, int folderId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionReleasesResponse?> GetCollectionItemsByReleaseAsync(string username, int releaseId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionFolderReleases?> GetCollectionItemsByFolderAsync(string username, long folderId, string? sort = null, string? sortOrder = null,
        int? page = null, int? perPage = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<AddToCollectionFolderResponse?> AddReleaseToCollectionFolderAsync(string username, long folderId, long releaseId,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateReleaseUserRatingAsync(string username, long releaseId, long instanceId, int rating,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task MoveReleaseToFolderAsync(string username, long currentFolderId, long releaseId, long instanceId,
        long targetFolderId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteReleaseFromFolderAsync(string username, long folderId, long releaseId, long instanceId,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionFields?> GetUserCollectionFieldsAsync(string username, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateReleaseInstanceFieldAsync(string username, long folderId, long releaseId, long instanceId, long fieldId,
        string value, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<UserCollectionValue?> GetUserCollectionValueAsync(string username, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}