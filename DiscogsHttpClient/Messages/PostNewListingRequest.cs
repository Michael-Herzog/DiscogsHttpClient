using Discogs.Objects.Marketplace;

namespace Discogs.Messages
{
    /// <summary>
    /// Create a Marketplace listing. 
    /// Authentication is required; the listing will be added to the authenticated user’s Inventory.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-release-rating-by-user-put
    public class PostNewListingRequest : DiscogsRequest<DiscogsPostListingResponseMessage>
    {
        public PostNewListingRequest(string releaseId)
            : base("/marketplace/listings?{0}", HttpMethod.Post)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(releaseId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }

        public PostNewListingRequest WithBody(DiscogsPostListingRequestMessage discogsListing)
        {
            Body = discogsListing;
            return this;
        }
    }
}
