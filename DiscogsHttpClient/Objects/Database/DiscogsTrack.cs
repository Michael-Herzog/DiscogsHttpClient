namespace Discogs.Objects.Database
{
    public class DiscogsTrack : DiscogsSubtrack
    {
        [JsonProperty("sub_tracks")]
        public DiscogsSubtrack[] SubTracks { get; set; }
    }
}
