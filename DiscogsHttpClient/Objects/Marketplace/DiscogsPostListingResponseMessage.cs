namespace DiscogsHttpClient.Objects.Marketplace
{
    internal class DiscogsPostListingResponseMessage
    {
        [JsonProperty("listing_id")]
        public string ListingId { get; set; }


        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}
