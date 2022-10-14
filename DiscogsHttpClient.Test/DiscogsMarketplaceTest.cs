using DiscogsHttpClient.Extensions;
using DiscogsHttpClient.Objects.Marketplace;

namespace DiscogsHttpClient.Test
{
    [TestClass]
    public class DiscogsMarketplaceTest
    {
        const string Token = "btCsJtxdcgbNmGVvDTEgLGcGXQkgGWXvtMYgYOwi";

        [TestMethod]
        public async Task TestGetListingRequest()
        {
            var client = new DiscogsHttpClient();
            var listing = await client.GetListingAsync(2129539472);

            Assert.IsNotNull(listing);
        }

        [TestMethod]
        public async Task TestPostNewListingRequestAsync()
        {
            if (!Token.HasValue())
            {
                return;
            }

            var listing = new DiscogsPostListingRequestMessage
            {
                ReleaseId = 651323,
                AllowOffers = true,
                Comments = "",
                Condition = Condition.NearMint,
                SleeveCondition = SleeveCondition.NearMint,
                ExternalId = "PD-1001",
                Price = 10.0M,
                Status = Status.Draft
            };

            // Authentication as the user is required.
            var client = new DiscogsHttpClient(Token);
            var releaseRating = await client.PostNewListingAsync(listing);

            Assert.IsNotNull(releaseRating);
        }
    }
}
