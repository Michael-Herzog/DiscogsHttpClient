using DiscogsHttpClient.Objects.Database;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Gets a discogs artist.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-artist
    public class GetArtistRequest : DiscogsRequest<DiscogsArtist>
    {
        public GetArtistRequest(string artistId)
            : base("/artists/{0}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(artistId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
