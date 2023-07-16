namespace Discogs.Objects.Marketplace
{
    public class DiscogsOriginalPrice
    {
        [JsonProperty("curr_abbr")]
        public string Currency { get; set; }

        [JsonProperty("curr_id")]
        public int CurrencyId { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}
