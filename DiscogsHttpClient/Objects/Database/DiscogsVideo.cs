namespace Discogs.Objects.Database
{
    public class DiscogsVideo
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("embed")]
        public bool Embed { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
