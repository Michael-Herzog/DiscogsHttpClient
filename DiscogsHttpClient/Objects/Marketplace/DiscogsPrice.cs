namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsPrice
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}
