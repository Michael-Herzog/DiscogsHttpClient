namespace Discogs.Objects.Marketplace
{
    public class DiscogsShippingPrice
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}
