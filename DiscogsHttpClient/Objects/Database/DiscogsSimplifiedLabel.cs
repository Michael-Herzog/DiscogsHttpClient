namespace Discogs.Objects.Database
{
    public class DiscogsSimplifiedLabel : DiscogsEntity
    {
        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
