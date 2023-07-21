using System.ComponentModel;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Discogs
{
    static public class DiscogsUtilities
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

        public static string GetEnumDescription(Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}
