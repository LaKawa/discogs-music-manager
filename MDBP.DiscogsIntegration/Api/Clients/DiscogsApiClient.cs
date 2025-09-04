using MusicDBPlayground.DiscogsIntegration.Api.Clients.Database;
using MusicDBPlayground.DiscogsIntegration.Api.Clients.UserCollection;
using MusicDBPlayground.DiscogsIntegration.Api.Clients.UserIdentity;
using MusicDBPlayground.DiscogsIntegration.Clients;
using MusicDBPlayground.DiscogsIntegration.Clients.Interfaces;
using MusicDBPlayground.DiscogsIntegration.Services;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients;

public class DiscogsApiClient : IDiscogsApi
{
    private HttpClient _httpClient;
    private DiscogsOAuthClient _oAuthClient;
    private HttpService _httpService;
    
    public IDiscogsDatabaseApi Database { get; }
    public IDiscogsInventoryExportApi InventoryExport { get; }
    public IDiscogsInventoryUploadApi InventoryUpload { get; }
    public IDiscogsMarketplaceApi Marketplace { get; }
    public IDiscogsUserIdentityApi UserIdentity { get; }
    public IDiscogsUserListsApi UserLists { get; }
    public IDiscogsUserWantlistApi UserWantlist { get; }
    public IDiscogsUserCollectionApi UserCollection { get; }
    
    
    public DiscogsApiClient(HttpClient httpClient, DiscogsOAuthClient oAuthClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _oAuthClient = oAuthClient ?? throw new ArgumentNullException(nameof(oAuthClient));
        
        _httpService = new HttpService(httpClient, _oAuthClient);
        
        Database = new DatabaseApiClient(_httpService);
        UserIdentity = new UserIdentityApiClient(_httpService);
        UserCollection = new UserCollectionApiClient(_httpService);
        
        
        //_httpClient.DefaultRequestHeaders.Add 
    }
}
