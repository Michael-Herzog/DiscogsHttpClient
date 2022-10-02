namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsSubtrack
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("duration")]
        public TimeSpan? Duration { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("extraartists")]
        public DiscogsReleaseArtist[] ExtraArtists { get; set; }

        [JsonProperty("artists")]
        public DiscogsReleaseArtist[] artists { get; set; }
    }
}
