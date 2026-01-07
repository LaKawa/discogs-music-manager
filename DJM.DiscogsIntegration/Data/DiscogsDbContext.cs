using Microsoft.EntityFrameworkCore;

namespace DJM.DiscogsIntegration.Data;

public class DiscogsDbContext : DbContext
{
   public DbSet<OAuthTokenEntity> OAuthTokens { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      var projectFolder = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "DJM.DiscogsIntegration");
      var dbPath = Path.Combine(projectFolder, "discogs.db");
      optionsBuilder.UseSqlite($"Data Source={dbPath}");
   }
}