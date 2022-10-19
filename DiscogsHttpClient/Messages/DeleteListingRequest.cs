namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Permanently remove a listing from the Marketplace.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:marketplace,header:marketplace-listing-delete
    public class DeleteListingRequest : DiscogsRequest<object>
    {
        public DeleteListingRequest(string listingId)
            : base("/marketplace/listings/{0}", HttpMethod.Delete)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(listingId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
