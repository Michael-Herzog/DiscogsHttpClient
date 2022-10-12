using DiscogsHttpClient.Objects.Database;
using Newtonsoft.Json.Linq;
using System.Web;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Retrieves a list of all Releases that are versions of this master. 
    /// </summary>
    /// https://www.discogs.com/developers#page:database,header:database-master-release
    public class GetMasterReleaseVersionsRequest : DiscogsRequest<DiscogsMasterReleaseVersions>
    {
        public GetMasterReleaseVersionsRequest(string masterId, DiscogsGetReleaseVersionsRequestMessage? filter = null)
            : base("/masters/{0}/versions{1}", HttpMethod.Get)
        {
            try
            {
                var query = DiscogsHelper.ConvertObjectToQuery(filter);

                Path = Path.FormatInvariant(Uri.EscapeDataString(masterId), query);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}