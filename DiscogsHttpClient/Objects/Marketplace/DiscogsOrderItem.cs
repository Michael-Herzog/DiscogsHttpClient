namespace Discogs.Objects.Marketplace
{
    public class DiscogsOrderItem
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("release")]
        public DiscogsOrderItemRelease Release { get; set; }

        [JsonProperty("price")]
        public DiscogsPrice Price { get; set; }
    }

    public class DiscogsOrderItemRelease : DiscogsEntity
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
