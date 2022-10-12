using DiscogsHttpClient.Extensions;

namespace DiscogsHttpClient.Test
{
    [TestClass]
    public class DiscogsDataTest
    {
        // Token is required for some action as delete or put user release rating
        const string Token = "";

        [TestMethod]
        public async Task TestGetReleaseRequest()
        {
            var client = new DiscogsHttpClient();
            var release = await client.GetReleaseRequestAsync(1707667);

            Assert.IsNotNull(release);
            Assert.IsTrue(release.Title == "Born Like This");
            Assert.IsTrue(release.Labels[0].CatNo == "LEX069LP");
        }

        [TestMethod]
        public async Task TestGetReleaseRequestAsync()
        {
            var client = new DiscogsHttpClient();
            var releaseRating = await client.GetReleaseRatingRequestAsync(9107382, "bigbankhank");

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
            var releaseRating = await client.DeleteReleaseRatingRequestAsync(9107382, "bigbankhank");

            Assert.IsNull(releaseRating);
        }

        [TestMethod]
        public async Task TestPutReleaseRequestAsync()
        {
            var client = new DiscogsHttpClient(Token);
            var releaseRating = await client.PutReleaseRatingRequestAsync(9107382, "bigbankhank", 5);

            Assert.IsNotNull(releaseRating);
            Assert.IsTrue(releaseRating.UserName == "bigbankhank");
            Assert.IsTrue(releaseRating.Rating == 5);
        }

        [TestMethod]
        public async Task TestGetCommunityReleaseRequestAsync()
        {
            var client = new DiscogsHttpClient();
            var releaseRating = await client.GetCommunityReleaseRatingRequestAsync(9107382);

            Assert.IsNotNull(releaseRating);
            Assert.IsTrue(releaseRating.Rating.Average > 4);
        }

        [TestMethod]
        public async Task TestGetReleaseStatsRequestAsync()
        {
            var client = new DiscogsHttpClient();
            var releaseStats = await client.GetReleaseStatsRequestAsync(9107382);

            Assert.IsNotNull(releaseStats);

            // TODO: Funny answer. Doesn't match API docs > "{\"is_offensive\": false}"

            //Assert.IsTrue(releaseStats.Want > 4);
            //Assert.IsTrue(releaseStats.Have > 4);
        }

        // TODO...
        // GetMasterRelease
        [TestMethod]
        public async Task TestGetMasterReleaseRequest()
        {
            var client = new DiscogsHttpClient();
            var masterRelease = await client.GetMasterReleaseRequestAsync(175562);

            Assert.IsNotNull(masterRelease);
            Assert.IsTrue(masterRelease.Title == "Joyful Rebellion");
            Assert.IsTrue(masterRelease.Artists[0].Name == "K-OS");
        }

        // GetMasterRelease Versions

        [TestMethod]
        public async Task TestGetArtistRequest()
        {
            var client = new DiscogsHttpClient();
            var artist = await client.GetArtistRequestAsync(109799);

            Assert.IsNotNull(artist);
            Assert.IsTrue(artist.Name == "K-OS");
        }

        // TODO...
        // GetArtistReleases Versions
        // GetLabel
        // GetAllLabelReleases
        // Search
    }
}