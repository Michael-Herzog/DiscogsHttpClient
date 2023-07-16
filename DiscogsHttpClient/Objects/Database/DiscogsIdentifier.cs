namespace Discogs.Objects.Database
{
    public class DiscogsIdentifier
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
