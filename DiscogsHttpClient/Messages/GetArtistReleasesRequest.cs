using Discogs.Objects.Database;

namespace Discogs.Messages
{
    /// <summary>
    /// Get an artist’s releases
    /// </summary>
    /// https://www.discogs.com/developers#page:database,header:database-artist-releases
    public class GetArtistReleasesRequest : DiscogsRequest<DiscogsArtistReleases>
    {
        public GetArtistReleasesRequest(string artistId, DiscogsGetArtistReleasesRequestMessage? filter = null)
            : base("/artists/{0}/releases{1}", HttpMethod.Get)
        {
            try
            {
                var query = DiscogsHelper.ConvertObjectToQuery(filter);

                Path = Path.FormatInvariant(Uri.EscapeDataString(artistId), query);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}