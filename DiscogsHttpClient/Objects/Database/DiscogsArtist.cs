namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsArtist : DiscogsEntity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("realname")]
        public string RealName { get; set; }

        [JsonProperty("images")]
        public DiscogsImage[] Images { get; set; }

        [JsonProperty("members")]
        public DiscogsGroupOrBandMember[] Members { get; set; }

        [JsonProperty("groups")]
        public DiscogsGroupOrBandMember[] Groups { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("namevariations")]
        public string[] NameVariations { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("data_quality")]
        public string DataQuality { get; set; }
    }
}
