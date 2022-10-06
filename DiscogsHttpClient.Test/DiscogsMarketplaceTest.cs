using DiscogsHttpClient.Extensions;
using DiscogsHttpClient.Objects.Marketplace;

namespace DiscogsHttpClient.Test
{
    [TestClass]
    public class DiscogsMarketplaceTest
    {
        const string Token = "";

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
                Condition = "Near Mint (NM or M-)",         // TODO: Create & use enum > Implement own JSONConverter
                SleeveCondition = "Near Mint (NM or M-)",   // TODO: Create & use enum
                ExternalId = "PD-1001",
                Price = 10.0M,
                Status = "Draft"                            // TODO: Create & use enum
            };

            // Authentication as the user is required.
            var client = new DiscogsHttpClient(Token);
            var releaseRating = await client.PostNewListingRequestAsync(listing);

            Assert.IsNotNull(releaseRating);
        }
    }
}
