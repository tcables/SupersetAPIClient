using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The comparison operator.</summary>
public enum ChartDataFilter_op
{
    [EnumMember(Value = "==")]
    EqualEqual,
    [EnumMember(Value = "!=")]
    ExclamationEqual,
    [EnumMember(Value = ">")]
    GreaterThan,
    [EnumMember(Value = "<")]
    LessThan,
    [EnumMember(Value = ">=")]
    GreaterThanEqual,
    [EnumMember(Value = "<=")]
    LessThanEqual,
    [EnumMember(Value = "LIKE")]
    LIKE,
    [EnumMember(Value = "ILIKE")]
    ILIKE,
    [EnumMember(Value = "IS NULL")]
    ISNULL,
    [EnumMember(Value = "IS NOT NULL")]
    ISNOTNULL,
    [EnumMember(Value = "IN")]
    IN,
    [EnumMember(Value = "NOT IN")]
    NOTIN,
    [EnumMember(Value = "IS TRUE")]
    ISTRUE,
    [EnumMember(Value = "IS FALSE")]
    ISFALSE,
    [EnumMember(Value = "TEMPORAL_RANGE")]
    TEMPORAL_RANGE,
}
