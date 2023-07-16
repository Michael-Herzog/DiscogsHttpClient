namespace Discogs.Objects.Database
{
    public class DiscogsRelease : DiscogsReleaseBase
    {
        [JsonProperty("extraartists")]
        public DiscogsReleaseArtist[] ExtraArtists { get; set; }

        [JsonProperty("labels")]
        public DiscogsReleaseLabel[] Labels { get; set; }

        [JsonProperty("companies")]
        public DiscogsReleaseLabel[] Companies { get; set; }

        [JsonProperty("formats")]
        public DiscogsFormat[] Formats { get; set; }

        [JsonProperty("identifiers")]
        public DiscogsIdentifier[] Identifiers { get; set; }

        [JsonProperty("community")]
        public DiscogsCommunity Community { get; set; }

        [JsonProperty("series")]
        public DiscogsReleaseLabel[] Series { get; set; }

        [JsonProperty("artists_sort")]
        public string ArtistsSort { get; set; }

        [JsonProperty("catno")]
        public string CatalogNumber { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_changed")]
        public DateTime DateChanged { get; set; }

        [JsonProperty("estimated_weight")]
        public int EstimatedWeight { get; set; }

        [JsonProperty("format_quantity")]
        public int FormatQuantity { get; set; }

        [JsonProperty("lowest_price")]
        public decimal? LowestPrice { get; set; }

        [JsonProperty("master_id")]
        public int MasterId { get; set; }

        [JsonProperty("master_url")]
        public string MasterUrl { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("num_for_sale")]
        public int NumForSale { get; set; }

        [JsonProperty("released")]
        public string Released { get; set; }

        [JsonProperty("released_formatted")]
        public string ReleasedFormatted { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }
}
