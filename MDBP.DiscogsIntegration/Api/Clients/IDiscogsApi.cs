using MusicDBPlayground.DiscogsIntegration.Api.Clients.Database;
using MusicDBPlayground.DiscogsIntegration.Api.Clients.UserCollection;
using MusicDBPlayground.DiscogsIntegration.Clients.Interfaces;

namespace MusicDBPlayground.DiscogsIntegration.Api.Clients;

public interface IDiscogsApi
{
   // combines all individual discogs api endpoints into one big interface 
   // decided to use composition to keep the main api client smaller
   IDiscogsDatabaseApi Database { get; }
   IDiscogsInventoryExportApi InventoryExport { get; }
   IDiscogsInventoryUploadApi InventoryUpload { get; }
   IDiscogsMarketplaceApi Marketplace { get; }
   IDiscogsUserIdentityApi UserIdentity { get; }
   IDiscogsUserListsApi UserLists { get; }
   IDiscogsUserWantlistApi UserWantlist { get; }
   IDiscogsUserCollectionApi UserCollection { get; }
}