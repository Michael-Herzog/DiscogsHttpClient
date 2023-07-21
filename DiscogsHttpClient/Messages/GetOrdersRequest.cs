using Discogs.Objects.Database;
using Discogs.Objects.Marketplace;

namespace Discogs.Messages
{
    /// <summary>
    /// Returns a list of the authenticated user’s orders.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:marketplace,header:marketplace-list-orders
    public class GetOrdersRequest : DiscogsRequest<DiscogsOrders>
    {
        public GetOrdersRequest(DiscogsGetOrdersRequestMessage? filter = null)
            : base("/marketplace/orders{0}", HttpMethod.Get)
        {
            try
            {
                var query = DiscogsUtilities.ConvertObjectToQuery(filter);

                Path = Path.FormatInvariant(query);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}