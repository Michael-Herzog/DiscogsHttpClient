namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsGroupOrBandMember : DiscogsEntity
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}
