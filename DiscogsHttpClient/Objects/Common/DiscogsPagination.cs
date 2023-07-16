namespace Discogs.Objects.Common
{
    public class DiscogsPagination
    {
        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }

        [JsonProperty("urls")]
        public DiscogsPaginatedUrls Urls { get; set; }
    }
}
