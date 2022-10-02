namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsReleaseStats
    {
        [JsonProperty("num_have")]
        public int Want { get; set; }

        [JsonProperty("num_want")]
        public int Have { get; set; }
    }
}
