using DiscogsHttpClient.Objects.Database;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// The Master resource represents a set of similar Releases. 
    /// Masters (also known as “master releases”) have a “main release” which is often the chronologically earliest.
    /// </summary>
    /// https://www.discogs.com/developers#page:database,header:database-master-release
    public class GetMasterReleaseRequest : DiscogsRequest<DiscogsMasterRelease>
    {
        public GetMasterReleaseRequest(string masterId)
            : base("/masters/{0}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(masterId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
