namespace Discogs.Objects.Marketplace
{
    public class DiscogsListing : DiscogsEntity
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public DiscogsPrice Price { get; set; }

        [JsonProperty("original_price")]
        public DiscogsOriginalPrice OriginalPrice { get; set; }

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

        [JsonProperty("seller")]
        public DiscogsSeller Seller { get; set; }

        [JsonProperty("shipping_price")]
        public DiscogsPrice ShippingPrice { get; set; }

        [JsonProperty("original_shipping_price")]
        public DiscogsOriginalPrice OriginalShippingPrice { get; set; }

        [JsonProperty("release")]
        public DiscogsReleaseDescription Release { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("audio")]
        public bool Audio { get; set; }
    }
}