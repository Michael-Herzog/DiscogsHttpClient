namespace Discogs.Objects.Marketplace
{
    public class DiscogsOrderItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("release")]
        public DiscogsOrderItemRelease Release { get; set; }

        [JsonProperty("price")]
        public DiscogsPrice Price { get; set; }

        [JsonProperty("media_condition")]
        public string MediaCondition { get; set; }

        [JsonProperty("sleeve_condition")]
        public string SleeveCondition { get; set; }
    }

    public class DiscogsOrderItemRelease : DiscogsEntity
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
