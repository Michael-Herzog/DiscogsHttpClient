using DiscogsHttpClient.Objects.Database;
using DiscogsHttpClient.Objects.Marketplace;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Issue a search query to the Discogs database.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-search
    public class GetSearchRequest : DiscogsRequest<DiscogsSearchResults>
    {
        public GetSearchRequest(DiscogsSearchRequestMessage? filter = null)
            : base("/database/search{0}", HttpMethod.Get)
        {
            try
            {
                var query = DiscogsHelper.ConvertObjectToQuery(filter);

                Path = Path.FormatInvariant(query);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}