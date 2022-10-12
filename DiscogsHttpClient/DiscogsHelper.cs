using Newtonsoft.Json.Linq;
using System.Web;

namespace DiscogsHttpClient
{
    static public class DiscogsHelper
    {
        public static string ConvertObjectToQuery(object filter)
        {
            var query = string.Empty;
            if (filter != null)
            {
                var test = JsonConvert.SerializeObject(filter);
                var jObj = JObject.FromObject(filter);

                query = "?" + string.Join("&",
                    jObj.Children().Cast<JProperty>()
                    .Select(jp => jp.Name + "=" + HttpUtility.UrlEncode(jp.Value.ToString())));
            }

            return query;
        }
    }
}
