using DiscogsHttpClient.Extensions;
using DiscogsHttpClient.Objects.Common;
using DiscogsHttpClient.Objects.Database;
using Microsoft.Extensions.Configuration;

namespace DiscogsHttpClient.Test
{
    [TestClass]
    public class DiscogsDataTest
    {
        // Token is required for some action as delete or put user release rating
        private string Token = "";

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();

            return config;
        }

        [TestInitialize]
        public void Setup()
        {
            var config = InitConfiguration();
            Token = config["Token"];
        }

        [TestMethod]
        public async Task TestGetReleaseRequest()
        {
            var client = new DiscogsHttpClient();
            var release = await client.GetReleaseAsync(1707667);

            Assert.IsNotNull(release);
            Assert.IsTrue(release.Title == "Born Like This");
            Assert.IsTrue(release.Labels[0].CatNo == "LEX069LP");
        }

        [TestMethod]
        public async Task TestGetReleaseRequestAsync()
        {
            var client = new DiscogsHttpClient();
            var releaseRating = await client.GetReleaseRatingAsync(9107382, "bigbankhank");

            Assert.IsNotNull(releaseRating);
            Assert.IsTrue(releaseRating.UserName == "bigbankhank");
            Assert.IsTrue(releaseRating.Rating == 5);
        }

        [TestMethod]
        public async Task TestDeleteReleaseRequestAsync()
        {
            if (!Token.HasValue())
            {
                return;
            }

            // Authentication as the user is required.
            var client = new DiscogsHttpClient(Token);
            var releaseRating = await client.DeleteReleaseRatingAsync(9107382, "bigbankhank");

            Assert.IsNull(releaseRating);
        }

        [TestMethod]
        public async Task TestPutReleaseRequestAsync()
        {
            var client = new DiscogsHttpClient(Token);
            var releaseRating = await client.PutReleaseRatingAsync(9107382, "bigbankhank", 5);

            Assert.IsNotNull(releaseRating);
            Assert.IsTrue(releaseRating.UserName == "bigbankhank");
            Assert.IsTrue(releaseRating.Rating == 5);
        }

        [TestMethod]
        public async Task TestGetCommunityReleaseRequestAsync()
        {
            var client = new DiscogsHttpClient();
            var releaseRating = await client.GetCommunityReleaseRatingAsync(9107382);

            Assert.IsNotNull(releaseRating);
            Assert.IsTrue(releaseRating.Rating.Average > 4);
        }

        [TestMethod]
        public async Task TestGetReleaseStatsRequestAsync()
        {
            var client = new DiscogsHttpClient();
            var releaseStats = await client.GetReleaseStatsAsync(9107382);

            Assert.IsNotNull(releaseStats);

            // TODO: Funny answer. Doesn't match API docs > "{\"is_offensive\": false}"

            //Assert.IsTrue(releaseStats.Want > 4);
            //Assert.IsTrue(releaseStats.Have > 4);
        }

        [TestMethod]
        public async Task TestGetMasterReleaseRequest()
        {
            var client = new DiscogsHttpClient();
            var masterRelease = await client.GetMasterReleaseAsync(175562);

            Assert.IsNotNull(masterRelease);
            Assert.IsTrue(masterRelease.Title == "Joyful Rebellion");
            Assert.IsTrue(masterRelease.Artists[0].Name == "K-OS");
        }

        [TestMethod]
        public async Task TestGetMasterReleaseVersionsRequest()
        {
            var client = new DiscogsHttpClient();
            var masterReleaseVersions = await client.GetMasterReleaseVersionsAsync(175562);

            Assert.IsNotNull(masterReleaseVersions);
            Assert.IsTrue(masterReleaseVersions.Versions[0].Title == "Joyful Rebellion");
        }

        [TestMethod]
        public async Task TestGetMasterReleaseVersionsRequestWithFilter()
        {
            var client = new DiscogsHttpClient();

            var filter = new DiscogsGetReleaseVersionsRequestMessage { 
                Country = "Japan",
            };

            var masterReleaseVersions = await client.GetMasterReleaseVersionsAsync(8883, filter);

            Assert.IsNotNull(masterReleaseVersions);
            Assert.IsTrue(masterReleaseVersions.Versions[0].Title == "Thriller");
        }
        
        [TestMethod]
        public async Task TestGetArtistRequest()
        {
            var client = new DiscogsHttpClient();
            var artist = await client.GetArtistAsync(109799);

            Assert.IsNotNull(artist);
            Assert.IsTrue(artist.Name == "K-OS");
        }

        [TestMethod]
        public async Task TestGetArtistReleasesRequest()
        {
            var client = new DiscogsHttpClient();

            var filter = new DiscogsGetArtistReleasesRequestMessage
            {
                SortOrder = DiscogsSortOrder.Ascending
            };

            var artistReleases = await client.GetArtistReleasesAsync(59792, filter);

            Assert.IsNotNull(artistReleases);
            Assert.IsTrue(artistReleases.Releases[0].Year == 1962);
        }

        [TestMethod]
        public async Task TestGetLabelRequest()
        {
            var client = new DiscogsHttpClient();
            var label = await client.GetLabelAsync(751);

            Assert.IsNotNull(label);
            Assert.IsTrue(label.Name == "Salsoul Records");
        }

        [TestMethod]
        public async Task TestGetLabelReleasesRequest()
        {
            var client = new DiscogsHttpClient();
            var labelReleases = await client.GetLabelReleasesAsync(751);

            Assert.IsNotNull(labelReleases);
            Assert.IsTrue(labelReleases.Releases[0].Title == "Rap-O Clap-O");
        }

        // TODO...
        // Search
    }
}