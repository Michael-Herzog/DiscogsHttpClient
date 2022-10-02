namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsReleaseLabel : DiscogsEntity
    {
        [JsonProperty("catno")]
        public string CatNo { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("entity_type_name")]
        public string EntityTypeName { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}
