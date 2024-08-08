using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Post processing operation type</summary>
public enum ChartDataPostProcessingOperation_operation
{
    [EnumMember(Value = "aggregate")]
#pragma warning disable CS1591
    Aggregate,
#pragma warning restore CS1591
    [EnumMember(Value = "boxplot")]
#pragma warning disable CS1591
    Boxplot,
#pragma warning restore CS1591
    [EnumMember(Value = "compare")]
#pragma warning disable CS1591
    Compare,
#pragma warning restore CS1591
    [EnumMember(Value = "contribution")]
#pragma warning disable CS1591
    Contribution,
#pragma warning restore CS1591
    [EnumMember(Value = "cum")]
#pragma warning disable CS1591
    Cum,
#pragma warning restore CS1591
    [EnumMember(Value = "diff")]
#pragma warning disable CS1591
    Diff,
#pragma warning restore CS1591
    [EnumMember(Value = "escape_separator")]
#pragma warning disable CS1591
    Escape_separator,
#pragma warning restore CS1591
    [EnumMember(Value = "flatten")]
#pragma warning disable CS1591
    Flatten,
#pragma warning restore CS1591
    [EnumMember(Value = "geodetic_parse")]
#pragma warning disable CS1591
    Geodetic_parse,
#pragma warning restore CS1591
    [EnumMember(Value = "geohash_decode")]
#pragma warning disable CS1591
    Geohash_decode,
#pragma warning restore CS1591
    [EnumMember(Value = "geohash_encode")]
#pragma warning disable CS1591
    Geohash_encode,
#pragma warning restore CS1591
    [EnumMember(Value = "pivot")]
#pragma warning disable CS1591
    Pivot,
#pragma warning restore CS1591
    [EnumMember(Value = "prophet")]
#pragma warning disable CS1591
    Prophet,
#pragma warning restore CS1591
    [EnumMember(Value = "rename")]
#pragma warning disable CS1591
    Rename,
#pragma warning restore CS1591
    [EnumMember(Value = "resample")]
#pragma warning disable CS1591
    Resample,
#pragma warning restore CS1591
    [EnumMember(Value = "rolling")]
#pragma warning disable CS1591
    Rolling,
#pragma warning restore CS1591
    [EnumMember(Value = "select")]
#pragma warning disable CS1591
    Select,
#pragma warning restore CS1591
    [EnumMember(Value = "sort")]
#pragma warning disable CS1591
    Sort,
#pragma warning restore CS1591
    [EnumMember(Value = "unescape_separator")]
#pragma warning disable CS1591
    Unescape_separator,
#pragma warning restore CS1591
}
