using Discogs.Objects.Common;

namespace Discogs.Objects.Database
{
    public class DiscogsArtistReleases
    {
        [JsonProperty("releases")]
        public DiscogsArtistRelease[] Releases { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}