using DiscogsHttpClient.Objects.Database;
using DiscogsHttpClient.Objects.Marketplace;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// The Listing resource allows you to view Marketplace listings.
    /// </summary>
    /// https://www.discogs.com/developers#page:marketplace,header:marketplace-listing-get
    public class GetListingRequest : DiscogsRequest<DiscogsListing>
    {
        public GetListingRequest(string listingId, string currencyCode = "")
            : base("/marketplace/listings/{0}{1}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(listingId), currencyCode.HasValue() ? $"?curr_abbr={currencyCode}" : string.Empty);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
