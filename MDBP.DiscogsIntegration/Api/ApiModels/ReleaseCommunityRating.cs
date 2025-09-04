using System.Text.Json.Serialization;

namespace MusicDBPlayground.DiscogsIntegration.Api.ApiModels;

public sealed class ReleaseCommunityRating
{
    [JsonPropertyName("release_id")]
    public int ReleaseId { get; init; }
    
    [JsonPropertyName("rating")]
    public Rating? Rating { get; init; }
}