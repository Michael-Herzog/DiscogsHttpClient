namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsSearchResultItem : DiscogsEntity
    {
        [JsonProperty("style")]
        public string[] Style { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("community")]
        public DiscogsCommunityInfo Community { get; set; }

        [JsonProperty("label")]
        public string[] Label { get; set; }

        [JsonProperty("catno")]
        public string CatalogNumber { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
