namespace Discogs.Objects.Database
{
    public class DiscogsCommunity : DiscogsCommunityInfo
    {
        [JsonProperty("contributors")]
        public DiscogsUser[] Contributors { get; set; }

        [JsonProperty("data_quality")]
        public string DataQuality { get; set; }

        [JsonProperty("rating")]
        public DiscogsRating Rating { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submitter")]
        public DiscogsUser Submitter { get; set; }
    }
}
