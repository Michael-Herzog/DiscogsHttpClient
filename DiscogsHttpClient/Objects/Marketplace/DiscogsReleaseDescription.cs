namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsReleaseDescription : DiscogsEntity
    {
        [JsonProperty("catalog_number")]
        public string CatalogNumber { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl   { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
