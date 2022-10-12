namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsLabelRelease : DiscogsEntity
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("catno")]
        public string CatalogNumber { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
