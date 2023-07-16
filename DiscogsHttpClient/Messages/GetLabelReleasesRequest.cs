using Discogs.Objects.Common;
using Discogs.Objects.Database;

namespace Discogs.Messages
{
    /// <summary>
    /// Returns a list of Releases associated with the label. 
    /// </summary>
    /// https://www.discogs.com/developers#page:database,header:database-all-label-releases
    public class GetLabelReleasesRequest : DiscogsRequest<DiscogsLabelReleases>
    {
        public GetLabelReleasesRequest(string labelId, DiscogsPaginationRequest? filter = null)
            : base("/labels/{0}/releases{1}", HttpMethod.Get)
        {
            try
            {
                var query = DiscogsHelper.ConvertObjectToQuery(filter);

                Path = Path.FormatInvariant(Uri.EscapeDataString(labelId), query);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}