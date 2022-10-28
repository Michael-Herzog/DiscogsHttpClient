using DiscogsHttpClient.Objects.Common;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DiscogsHttpClient.Objects.Database
{
    /// <summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-search-get
    /// </summary>
    public class DiscogsSearchRequestMessage : DiscogsPaginationRequest
    {
        /// <summary>
        /// Your search query.
        /// </summary>
        [JsonProperty("query")]
        public string query { get; set; }

        /// <summary>
        /// One of release, master, artist, label
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public SearchType SearchType { get; set; }

        /// <summary>
        /// Search by combined “Artist Name - Release Title” title field.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Search release titles.
        /// </summary>
        [JsonProperty("release_title")]
        public string ReleaseTitle { get; set; }

        /// <summary>
        /// Search release credits.
        /// </summary>
        [JsonProperty("credit")]
        public string Credit { get; set; }

        /// <summary>
        /// Search artist names.
        /// </summary>
        [JsonProperty("artist")]
        public string Artist { get; set; }

        /// <summary>
        /// Search artist ANV.
        /// </summary>
        [JsonProperty("anv")]
        public string Anv { get; set; }

        /// <summary>
        /// Search label names.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Search genres.
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// Search styles.
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }

        /// <summary>
        /// Search release country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Search release year.
        /// </summary>
        [JsonProperty("year")]
        public string Year { get; set; }

        /// <summary>
        /// Search formats.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Search catalog number.
        /// </summary>
        [JsonProperty("catno")]
        public string CatalogNumber { get; set; }

        /// <summary>
        /// Search barcodes.
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Search track titles.
        /// </summary>
        [JsonProperty("track")]
        public string Track { get; set; }

        /// <summary>
        /// Search submitter username.
        /// </summary>
        [JsonProperty("submitter")]
        public string Submitter { get; set; }

        /// <summary>
        /// Search contributor usernames.
        /// </summary>
        [JsonProperty("contributor")]
        public string Contributor { get; set; }
    }

    public enum SearchType
    {
        [EnumMember(Value = "release")]
        Release,

        [EnumMember(Value = "master")]
        Master,

        [EnumMember(Value = "artist")]
        Artist,

        [EnumMember(Value = "label")]
        Label
    }
}