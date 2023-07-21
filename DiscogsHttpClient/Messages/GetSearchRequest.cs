using Discogs.Objects.Database;
using Discogs.Objects.Marketplace;

namespace Discogs.Messages
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