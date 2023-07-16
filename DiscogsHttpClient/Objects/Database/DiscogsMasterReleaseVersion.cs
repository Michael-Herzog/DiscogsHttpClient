namespace Discogs.Objects.Database
{
    public class DiscogsMasterReleaseVersion : DiscogsEntity
    {
        [JsonProperty("catno")]
        public string CatNo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        // TODO: cast to date time
        [JsonProperty("released")]
        //public DateTime? Released { get; set; }
        public string Released { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}