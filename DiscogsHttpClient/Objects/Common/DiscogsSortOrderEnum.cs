using System.Runtime.Serialization;

namespace DiscogsHttpClient.Objects.Common
{
    public enum DiscogsSortOrder
    {
        [EnumMember(Value = "asc")]
        Ascending,

        [EnumMember(Value = "desc")]
        Descending
    }
}
