global using DiscogsHttpClient.Extensions;
global using DiscogsHttpClient.Messages;
global using DiscogsHttpClient.Objects;
global using Newtonsoft.Json;
using DiscogsHttpClient.Objects.Common;
using DiscogsHttpClient.Objects.Database;
using DiscogsHttpClient.Objects.Marketplace;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace DiscogsHttpClient
{
    public class DiscogsHttpClient
    {
        const string ApiUrl = "https://api.discogs.com";
        
        private readonly HttpClient _client;
        private readonly string _token;

        public DiscogsHttpClient(string token = "")
        {
            _client = new HttpClient();
            _token = token;
        }

        #region Database requests
        // https://www.discogs.com/developers/accessing.html#page:database

        public async Task<DiscogsRelease> GetReleaseAsync(int releaseId)
        {
            var getReleaseRequest = new GetReleaseRequest(releaseId.ToString());
            var response = await ExecuteRequestAsync(getReleaseRequest);
            var release = response.Body<DiscogsRelease>();

            return release;
        }

        public async Task<DiscogsReleaseRating> GetReleaseRatingAsync(int releaseId, string userName)
        {
            var getReleaseRatingRequest = new GetReleaseRatingRequest(releaseId.ToString(), userName);
            var response = await ExecuteRequestAsync(getReleaseRatingRequest);
            var releaseRating = response.Body<DiscogsReleaseRating>();

            return releaseRating;
        }

        public async Task<DiscogsReleaseRating> DeleteReleaseRatingAsync(int releaseId, string userName)
        {
            var deleteReleaseRatingRequest = new DeleteReleaseRatingRequest(releaseId.ToString(), userName);
            var response = await ExecuteRequestAsync(deleteReleaseRatingRequest);
            var releaseRating = response.Body<DiscogsReleaseRating>();

            return releaseRating;
        }

        public async Task<DiscogsReleaseRating> PutReleaseRatingAsync(int releaseId, string userName, int rating)
        {
            var discogsReleaseRating = new DiscogsReleaseRating
            {
                ReleaseId = releaseId,
                UserName = userName,
                Rating = rating
            };

            var putReleaseRatingRequest = new PutReleaseRatingRequest(releaseId.ToString(), userName)
                .WithBody(discogsReleaseRating);
            
            var response = await ExecuteRequestAsync(putReleaseRatingRequest);
            var releaseRating = response.Body<DiscogsReleaseRating>();

            return releaseRating;
        }

        public async Task<DiscogsCommunityReleaseRating> GetCommunityReleaseRatingAsync(int releaseId)
        {
            var getCommunityReleaseRatingRequest = new GetCommunityReleaseRatingRequest(releaseId.ToString());
            var response = await ExecuteRequestAsync(getCommunityReleaseRatingRequest);
            var communityReleaseRating = response.Body<DiscogsCommunityReleaseRating>();

            return communityReleaseRating;
        }

        public async Task<DiscogsReleaseStats> GetReleaseStatsAsync(int releaseId)
        {
            var getReleaseStatsRequest = new GetReleaseStatsRequest(releaseId.ToString());
            var response = await ExecuteRequestAsync(getReleaseStatsRequest);
            var releaseStats = response.Body<DiscogsReleaseStats>();

            return releaseStats;
        }

        public async Task<DiscogsMasterRelease> GetMasterReleaseAsync(int masterId)
        {
            var getMasterReleaseRequest = new GetMasterReleaseRequest(masterId.ToString());
            var response = await ExecuteRequestAsync(getMasterReleaseRequest);
            var masterRelease = response.Body<DiscogsMasterRelease>();

            return masterRelease;
        }

        public async Task<DiscogsMasterReleaseVersions> GetMasterReleaseVersionsAsync(int masterId, DiscogsGetReleaseVersionsRequestMessage? filter = null)
        {
            var getMasterReleaseVersionsRequest = new GetMasterReleaseVersionsRequest(masterId.ToString(), filter);
            var response = await ExecuteRequestAsync(getMasterReleaseVersionsRequest);
            var masterReleaseVersions = response.Body<DiscogsMasterReleaseVersions>();

            return masterReleaseVersions;
        }

        public async Task<DiscogsArtist> GetArtistAsync(int artistId)
        {
            var getArtistRequest = new GetArtistRequest(artistId.ToString());
            var response = await ExecuteRequestAsync(getArtistRequest);
            var artist = response.Body<DiscogsArtist>();

            return artist;
        }

        public async Task<DiscogsArtistReleases> GetArtistReleasesAsync(int artistId, DiscogsGetArtistReleasesRequestMessage? filter = null)
        {
            var getArtistReleasesRequest = new GetArtistReleasesRequest(artistId.ToString(), filter);
            var response = await ExecuteRequestAsync(getArtistReleasesRequest);
            var artistReleases = response.Body<DiscogsArtistReleases>();

            return artistReleases;
        }

        public async Task<DiscogsLabel> GetLabelAsync(int labelId)
        {
            var getLabelRequest = new GetLabelRequest(labelId.ToString());
            var response = await ExecuteRequestAsync(getLabelRequest);
            var label = response.Body<DiscogsLabel>();

            return label;
        }

        public async Task<DiscogsLabelReleases> GetLabelReleasesAsync(int labelId, DiscogsPaginationRequest? filter = null)
        {
            var getLabelReleasesRequest = new GetLabelReleasesRequest(labelId.ToString(), filter);
            var response = await ExecuteRequestAsync(getLabelReleasesRequest);
            var labelReleases = response.Body<DiscogsLabelReleases>();

            return labelReleases;
        }

        #endregion

        #region Marketplace requests

        public async Task<DiscogsListing> GetListingAsync(int listingId)
        {
            var getListingRequest = new GetListingRequest(listingId.ToString());
            var response = await ExecuteRequestAsync(getListingRequest);
            var listing = response.Body<DiscogsListing>();

            return listing;
        }

        public async Task<bool> DeleteListingAsync(long listingId)
        {
            var deleteListingRequest = new DeleteListingRequest(listingId.ToString());
            var response = await ExecuteRequestAsync(deleteListingRequest);
            
            return response.Status == HttpStatusCode.OK;
        }

        public async Task<DiscogsPostListingResponseMessage> PostNewListingAsync(DiscogsPostListingRequestMessage discogsPostListing)
        {
            var postNewListingRequest = new PostNewListingRequest(discogsPostListing.ReleaseId.ToString())
                .WithBody(discogsPostListing);

            var response = await ExecuteRequestAsync(postNewListingRequest);
            var listingResponse = response.Body<DiscogsPostListingResponseMessage>();

            return listingResponse;
        }

        #endregion

        #region Infrastructure

        public virtual async Task<DiscogsResponse> ExecuteRequestAsync<TRequest>(
            TRequest request,
            CancellationToken cancelToken = default)
            where TRequest : DiscogsRequest
        {
            request = request.Clone<TRequest>();

            // Discogs requires a proper user agent.
            request.Headers.UserAgent.Add(new ProductInfoHeaderValue("C#DiscogsHttpClient", "1.0"));

            request.RequestUri = new Uri(ApiUrl + request.Path.EnsureStartsWith('/'));

            if (request.Body != null)
            {
                request.Content = SerializeRequest(request);
            }
            else
            {
                // Support empty messages
                request.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
            }

            // Token is not be needed for every request so we only add it if the client is initialized with it.
            if ((request.Headers.Authorization == null || !request.Headers.Authorization.Parameter.HasValue()) && _token.HasValue())
            {
                request.Headers.Add("Authorization", $"Discogs token={_token}");
            }

            var response = await _client.SendAsync(request, cancelToken);

            if (response.IsSuccessStatusCode)
            {
                object responseBody = null;

                if (response.Content.Headers.ContentType != null)
                {
                    responseBody = await DeserializeResponseAsync(response.Content, request.ResponseType);
                }

                return new DiscogsResponse(response.StatusCode, response.Headers, responseBody);
            }
            else
            {
                var responseBody = await response.Content.ReadAsStringAsync(cancelToken);
                throw new DiscogsException(responseBody, new DiscogsResponse(
                    response.StatusCode,
                    response.Headers,
                    responseBody));
            }
        }

        protected virtual HttpContent SerializeRequest(DiscogsRequest request)
        {
            if (request.ContentType == null)
            {
                throw new IOException("HttpRequest did not have content-type header set");
            }

            request.ContentType = request.ContentType.ToLower();

            HttpContent content = null;

            if (request.ContentType == "application/json")
            {
                var json = JsonConvert.SerializeObject(request.Body);
                content = new StringContent(json, Encoding.UTF8, "application/json");
            }
            else if (request.ContentType == "application/x-www-form-urlencoded")
            {
                content = new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)request.Body);
            }

            if (content == null)
            {
                throw new IOException($"Unable to serialize request with Content-Type {request.ContentType} because it is not supported.");
            }

            return content;
        }

        protected virtual async Task<object> DeserializeResponseAsync(HttpContent content, Type responseType)
        {
            if (content.Headers.ContentType == null)
            {
                throw new IOException("HTTP response did not have content-type header set");
            }

            var contentType = content.Headers.ContentType.ToString().ToLower();

            // ContentType can also be 'application/json; charset=utf-8'
            if (contentType.Contains("application/json"))
            {
                var message = JsonConvert.DeserializeObject(await content.ReadAsStringAsync(), responseType);

                var test = await content.ReadAsStringAsync();

                return message;
            }
            else if (contentType.Contains("text/plain"))
            {
                // text/plain will be returned for DELETE requests.
                return null;
            }
            else
            {
                throw new IOException($"Unable to deserialize response with Content-Type {contentType} because it is not supported.");
            }
        }

        #endregion
    }
}