using DiscogsHttpClient.Objects.Common;
using System.Runtime.Serialization;

namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsGetReleaseVersionsRequestMessage : DiscogsPaginationRequest
    {
        /// <summary>
        /// The format to filter (Example: Vinyl)
        /// </summary>
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// The label to filter (Example: Scorpio Music)
        /// </summary>
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// The release year to filter (Example: 1992)
        /// </summary>
        [JsonProperty("released", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Released { get; set; }

        /// <summary>
        /// The country to filter (Example: Belgium)
        /// </summary>
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("sort", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public RelaesesSort SortBy { get; set; }

        [JsonProperty("sort_order", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DiscogsSortOrder SortOrder { get; set; }
    }

    public enum RelaesesSort
    {
        [EnumMember(Value = "released")]
        Released,

        [EnumMember(Value = "title")]
        Title,

        [EnumMember(Value = "format")]
        Format,

        [EnumMember(Value = "label")]
        Label,

        [EnumMember(Value = "catno")]
        CatalogNumber,

        [EnumMember(Value = "country")]
        Country
    }
}