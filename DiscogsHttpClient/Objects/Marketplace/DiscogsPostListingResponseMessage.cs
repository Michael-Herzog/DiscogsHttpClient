namespace Discogs.Objects.Marketplace
{
    public class DiscogsPostListingResponseMessage
    {
        [JsonProperty("listing_id")]
        public long ListingId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}
