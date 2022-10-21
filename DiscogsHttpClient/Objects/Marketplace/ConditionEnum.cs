using System.ComponentModel;
using System.Runtime.Serialization;

namespace DiscogsHttpClient.Objects.Marketplace
{
    public enum Condition
    {
        [EnumMember(Value = "Mint (M)")]
        [Description("Mint (M)")]
        Mint,

        [EnumMember(Value = "Near Mint (NM or M-)")]
        NearMint,

        [EnumMember(Value = "Very Good Plus (VG+)")]
        VeryGoodPlus,

        [EnumMember(Value = "Very Good (VG)")]
        VeryGood,

        [EnumMember(Value = "Good Plus (G+)")]
        GoodPlus,

        [EnumMember(Value = "Good (G)")]
        Good,

        [EnumMember(Value = "Fair (F)")]
        Fair,

        [EnumMember(Value = "Poor (P)")]
        Poor
    }
}
