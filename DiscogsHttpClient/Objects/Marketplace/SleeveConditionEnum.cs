﻿using System.Runtime.Serialization;

namespace Discogs.Objects.Marketplace
{
    public enum SleeveCondition
    {
        [EnumMember(Value = "Mint (M)")]
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
        Poor,

        [EnumMember(Value = "Generic")]
        Generic,

        [EnumMember(Value = "Not Graded")]
        NotGraded,

        [EnumMember(Value = "No Cover")]
        NoCover
    }
}
