namespace Discogs.Objects.Database
{
    public class DiscogsReleaseBase : DiscogsEntity
    {
        [JsonProperty("artists")]
        public DiscogsReleaseArtist[] Artists { get; set; }

        [JsonProperty("videos")]
        public DiscogsVideo[] Videos { get; set; }

        [JsonProperty("images")]
        public DiscogsImage[] Images { get; set; }

        [JsonProperty("tracklist")]
        public DiscogsTrack[] Tracklist { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("data_quality")]
        public string DataQuality { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("genres")]
        public string[] Genres { get; set; }

        [JsonProperty("styles")]
        public string[] Styles { get; set; }
    }
}
