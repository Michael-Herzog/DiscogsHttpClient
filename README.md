# DiscogsHttpClient

Simple HttpClient to work with *Discogs API* for *NET core*. The only dependency is *Newtonsoft.Json*. 

To run tests which need a token add the file *appsettings.json* with the following content.

    {
      "Token": ""
    }

## Usage Examples ##

For the complete reference of all supported functions visit the test classes in the test project.

**Get Release**

            var client = new DiscogsHttpClient();
            var release = await client.GetReleaseAsync(1707667);

**Post Listing**

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

