using Newtonsoft.Json.Converters;

namespace Discogs.Objects.Marketplace
{
    /// <summary>
    /// Object to post a marketplace listing.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:marketplace,header:marketplace-listing-post
    public class DiscogsPostListingRequestMessage
    {
        /// <summary>
        /// The ID of the listing you are fetching.
        /// </summary>
        [JsonProperty("listing_id")]
        public int ListingId { get; set; }

        /// <summary>
        /// The ID of the release you are posting.
        /// </summary>
        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        /// <summary>
        /// The condition of the release you are posting. 
        /// </summary>
        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        /// <summary>
        /// The condition of the sleeve of the item you are posting.
        /// </summary>
        [JsonProperty("sleeve_condition")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SleeveCondition SleeveCondition { get; set; }

        /// <summary>
        /// The price of the item (in the seller’s currency).
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Any remarks about the item that will be displayed to buyers.
        /// </summary>
        [JsonProperty("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Whether or not to allow buyers to make offers on the item. Defaults to false.
        /// </summary>
        [JsonProperty("allow_offers")]
        public bool AllowOffers { get; set; }

        /// <summary>
        /// The status of the listing. Defaults to For Sale. 
        /// Options are For Sale (the listing is ready to be shown on the Marketplace) 
        /// and Draft (the listing is not ready for public display).
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; }

        /// <summary>
        /// A freeform field that can be used for the seller’s own reference. 
        /// Information stored here will not be displayed to anyone other than the seller. 
        /// This field is called “Private Comments” on the Discogs website.
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// A freeform field that is intended to help identify an item’s physical storage location. 
        /// Information stored here will not be displayed to anyone other than the seller. 
        /// This field will be visible on the inventory management page and will be available in inventory exports via the website.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// The weight, in grams, of this listing, for the purpose of calculating shipping. 
        /// Set this field to auto to have the weight automatically estimated for you.
        /// </summary>
        [JsonProperty("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// The number of items this listing counts as, for the purpose of calculating shipping. 
        /// This field is called “Counts As” on the Discogs website. 
        /// Set this field to auto to have the quantity automatically estimated for you.
        /// </summary>
        [JsonProperty("format_quantity")]
        public decimal FormatQuantity { get; set; }
    }
}