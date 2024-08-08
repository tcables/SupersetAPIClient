
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The comparison operator.</summary>
public enum ChartDataFilter_op
{
    [EnumMember(Value = "==")]
#pragma warning disable CS1591
    EqualEqual,
#pragma warning restore CS1591
    [EnumMember(Value = "!=")]
#pragma warning disable CS1591
    ExclamationEqual,
#pragma warning restore CS1591
    [EnumMember(Value = ">")]
#pragma warning disable CS1591
    GreaterThan,
#pragma warning restore CS1591
    [EnumMember(Value = "<")]
#pragma warning disable CS1591
    LessThan,
#pragma warning restore CS1591
    [EnumMember(Value = ">=")]
#pragma warning disable CS1591
    GreaterThanEqual,
#pragma warning restore CS1591
    [EnumMember(Value = "<=")]
#pragma warning disable CS1591
    LessThanEqual,
#pragma warning restore CS1591
    [EnumMember(Value = "LIKE")]
#pragma warning disable CS1591
    LIKE,
#pragma warning restore CS1591
    [EnumMember(Value = "ILIKE")]
#pragma warning disable CS1591
    ILIKE,
#pragma warning restore CS1591
    [EnumMember(Value = "IS NULL")]
#pragma warning disable CS1591
    ISNULL,
#pragma warning restore CS1591
    [EnumMember(Value = "IS NOT NULL")]
#pragma warning disable CS1591
    ISNOTNULL,
#pragma warning restore CS1591
    [EnumMember(Value = "IN")]
#pragma warning disable CS1591
    IN,
#pragma warning restore CS1591
    [EnumMember(Value = "NOT IN")]
#pragma warning disable CS1591
    NOTIN,
#pragma warning restore CS1591
    [EnumMember(Value = "IS TRUE")]
#pragma warning disable CS1591
    ISTRUE,
#pragma warning restore CS1591
    [EnumMember(Value = "IS FALSE")]
#pragma warning disable CS1591
    ISFALSE,
#pragma warning restore CS1591
    [EnumMember(Value = "TEMPORAL_RANGE")]
#pragma warning disable CS1591
    TEMPORAL_RANGE,
#pragma warning restore CS1591
}
