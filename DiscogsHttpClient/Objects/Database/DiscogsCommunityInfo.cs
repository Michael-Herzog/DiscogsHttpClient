namespace Discogs.Objects.Database
{
    public class DiscogsCommunityInfo
    {
        [JsonProperty("want")]
        public int Want { get; set; }

        [JsonProperty("have")]
        public int Have { get; set; }
    }
}
