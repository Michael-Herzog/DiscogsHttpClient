using DiscogsHttpClient.Objects.Marketplace;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// View the data associated with an order.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:marketplace,header:marketplace-order
    public class GetOrderRequest : DiscogsRequest<DiscogsOrder>
    {
        public GetOrderRequest(string orderId)
            : base("/marketplace/orders/{0}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(orderId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
