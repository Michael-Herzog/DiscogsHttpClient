using System.Runtime.Serialization;

namespace Discogs.Objects.Marketplace
{
    public enum Status
    {
        [EnumMember(Value = "Draft")]
        Draft,

        [EnumMember(Value = "For Sale")]
        ForSale
    }
}
