namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsMasterRelease : DiscogsReleaseBase
    {
        [JsonProperty("main_release")]
        public int MainRelease { get; set; }

        [JsonProperty("main_release_url ")]
        public string MainReleaseUrl { get; set; }

        [JsonProperty("most_recent_release")]
        public int MostRecentRelease { get; set; }

        [JsonProperty("most_recent_release_url")]
        public string MostRecentReleaseUrl { get; set; }

        [JsonProperty("num_for_sale")]
        public int NumForSale { get; set; }

        [JsonProperty("lowest_price")]
        public decimal LowestPrice { get; set; }

        [JsonProperty("versions_url")]
        public string VersionsUrl { get; set; }
    }
}
