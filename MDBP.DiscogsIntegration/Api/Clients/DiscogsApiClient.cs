using MusicDBPlayground.DiscogsIntegration.Api.Clients.Database;
using MusicDBPlayground.DiscogsIntegration.Api.Clients.UserCollection;
using MusicDBPlayground.DiscogsIntegration.Clients;
using MusicDBPlayground.DiscogsIntegration.Clients.Interfaces;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients;

public class DiscogsApiClient : IDiscogsApi
{
    private HttpClient _httpClient;
    private DiscogsOAuthClient _oAuthClient;
    
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
        
        Database = new DatabaseApiClient(_httpClient, _oAuthClient);
        
        //_httpClient.DefaultRequestHeaders.Add 
    }
    
    public async Task<string> GetIdentityAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://api.discogs.com/oauth/identity");
        
        _oAuthClient.SignRequest(request);
        
        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadAsStringAsync();
    }

    
}
