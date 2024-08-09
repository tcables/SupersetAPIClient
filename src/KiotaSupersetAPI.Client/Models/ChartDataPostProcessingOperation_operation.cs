using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Post processing operation type</summary>
public enum ChartDataPostProcessingOperation_operation
{
    [EnumMember(Value = "aggregate")]
    Aggregate,
    [EnumMember(Value = "boxplot")]
    Boxplot,
    [EnumMember(Value = "compare")]
    Compare,
    [EnumMember(Value = "contribution")]
    Contribution,
    [EnumMember(Value = "cum")]
    Cum,
    [EnumMember(Value = "diff")]
    Diff,
    [EnumMember(Value = "escape_separator")]
    Escape_separator,
    [EnumMember(Value = "flatten")]
    Flatten,
    [EnumMember(Value = "geodetic_parse")]
    Geodetic_parse,
    [EnumMember(Value = "geohash_decode")]
    Geohash_decode,
    [EnumMember(Value = "geohash_encode")]
    Geohash_encode,
    [EnumMember(Value = "pivot")]
    Pivot,
    [EnumMember(Value = "prophet")]
    Prophet,
    [EnumMember(Value = "rename")]
    Rename,
    [EnumMember(Value = "resample")]
    Resample,
    [EnumMember(Value = "rolling")]
    Rolling,
    [EnumMember(Value = "select")]
    Select,
    [EnumMember(Value = "sort")]
    Sort,
    [EnumMember(Value = "unescape_separator")]
    Unescape_separator,
}
