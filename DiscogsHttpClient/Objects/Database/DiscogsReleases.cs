using Discogs.Objects.Common;

namespace Discogs.Objects.Database
{
    public class DiscogsLabelReleases
    {
        [JsonProperty("releases")]
        public DiscogsLabelRelease[] Releases { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}