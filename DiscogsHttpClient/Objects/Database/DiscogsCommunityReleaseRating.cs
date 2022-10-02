namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsCommunityReleaseRating
    {
        [JsonProperty("rating")]
        public DiscogsRating Rating { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }
    }
}
