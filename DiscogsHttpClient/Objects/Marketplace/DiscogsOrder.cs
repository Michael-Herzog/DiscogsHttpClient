namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsOrder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("messages_url")]
        public string MessagesUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("next_status")]
        public string[] NextStatus { get; set; }

        [JsonProperty("fee")]
        public DiscogsPrice Fee { get; set; }

        // TODO: cast
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("items")]
        public DiscogsOrderItem[] OrderItems { get; set; }

        [JsonProperty("shipping")]
        public DiscogsShippingPrice Shipping { get; set; }

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("additional_instructions")]
        public string AdditionalInstructions { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("seller")]
        public DiscogsSeller Seller { get; set; }

        // TOOD: cast
        [JsonProperty("last_activity")]
        public string LastActivity { get; set; }

        // TODO: Rename DiscogsSeller into something more generic.
        [JsonProperty("buyer")]
        public DiscogsSeller Buyer { get; set; }

        [JsonProperty("total")]
        public DiscogsPrice total { get; set; }
    }
}
