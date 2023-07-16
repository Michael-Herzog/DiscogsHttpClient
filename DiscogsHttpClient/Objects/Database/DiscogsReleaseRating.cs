namespace Discogs.Objects.Database
{
    public class DiscogsReleaseRating
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }
    }
}
