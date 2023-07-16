namespace Discogs.Objects.Database
{
    public class DiscogsLabel : DiscogsEntity
    {
        [JsonProperty("images")]
        public DiscogsImage[] Images { get; set; }

        [JsonProperty("sublabels")]
        public DiscogsSimplifiedLabel[] Sublabels { get; set; }

        [JsonProperty("parent_label")]
        public DiscogsSimplifiedLabel ParentLabel { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contact_info")]
        public string ContactInfo { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("data_quality")]
        public string DataQuality { get; set; }
    }
}
