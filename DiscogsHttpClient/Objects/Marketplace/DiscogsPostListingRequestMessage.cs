namespace DiscogsHttpClient.Objects.Marketplace
{
    /// <summary>
    /// TODO: Finish the job
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:marketplace,header:marketplace-listing-post
    public class DiscogsPostListingRequestMessage
    {
        [JsonProperty("listing_id")]
        public int ListingId { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        // TODO...
    }
}