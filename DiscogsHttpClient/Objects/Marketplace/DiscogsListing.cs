namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsListing : DiscogsEntity
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public DiscogsPrice Price { get; set; }

        [JsonProperty("original_price")]
        public OriginalPrice OriginalPrice { get; set; }

        [JsonProperty("allow_offers")]
        public bool AllowOffers { get; set; }

        [JsonProperty("sleeve_condition")]
        public string SleeveCondition { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        //TODO: Convert to date time
        [JsonProperty("posted")]
        public string PostedDate { get; set; }

        [JsonProperty("ships_from")]
        public string ShipsFrom { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        // TODO ...
    }

    // TODO make own files
    public class DiscogsPrice
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
    }

    public class OriginalPrice
    {
        [JsonProperty("curr_abbr")]
        public string Currency { get; set; }

        [JsonProperty("curr_id")]
        public int CurrencyId { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}