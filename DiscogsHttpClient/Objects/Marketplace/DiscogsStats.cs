namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsStats
    {
        [JsonProperty("rating")]
        public string rating { get; set; }

        [JsonProperty("stars")]
        public double stars { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
