using DiscogsHttpClient.Extensions;
using DiscogsHttpClient.Objects.Common;
using DiscogsHttpClient.Objects.Database;
using DiscogsHttpClient.Objects.Marketplace;
using Microsoft.Extensions.Configuration;

namespace DiscogsHttpClient.Test
{
    [TestClass]
    public class DiscogsMarketplaceTest
    {
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
                Condition =  Condition.NearMint,
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

        [TestMethod]
        public async Task TestDeleteListingRequest()
        {
            var client = new DiscogsHttpClient(Token);
            var response = await client.DeleteListingAsync(837276714);

            Assert.IsTrue(response);
        }

        [TestMethod]
        public async Task TestGetOrderRequest()
        {
            var client = new DiscogsHttpClient(Token);
            var order = await client.GetOrderAsync("302490-336");

            Assert.IsNotNull(order);
        }

        [TestMethod]
        public async Task TestGetOrdersRequest()
        {
            var client = new DiscogsHttpClient(Token);

            var filter = new DiscogsGetOrdersRequestMessage
            {
                SortOrder = DiscogsSortOrder.Ascending
            };

            var orders = await client.GetOrdersAsync(filter);

            Assert.IsNotNull(orders);
        }
    }
}