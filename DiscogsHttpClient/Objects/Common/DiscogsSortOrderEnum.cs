using System.Runtime.Serialization;

namespace Discogs.Objects.Common
{
    public enum DiscogsSortOrder
    {
        [EnumMember(Value = "asc")]
        Ascending,

        [EnumMember(Value = "desc")]
        Descending
    }
}
