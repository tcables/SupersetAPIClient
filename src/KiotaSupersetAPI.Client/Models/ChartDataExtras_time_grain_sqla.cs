using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>To what level of granularity should the temporal column be aggregated. Supports [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601#Durations) durations.</summary>
public enum ChartDataExtras_time_grain_sqla
{
    [EnumMember(Value = "PT1S")]
    PT1S,
    [EnumMember(Value = "PT5S")]
    PT5S,
    [EnumMember(Value = "PT30S")]
    PT30S,
    [EnumMember(Value = "PT1M")]
    PT1M,
    [EnumMember(Value = "PT5M")]
    PT5M,
    [EnumMember(Value = "PT10M")]
    PT10M,
    [EnumMember(Value = "PT15M")]
    PT15M,
    [EnumMember(Value = "PT30M")]
    PT30M,
    [EnumMember(Value = "PT1H")]
    PT1H,
    [EnumMember(Value = "PT6H")]
    PT6H,
    [EnumMember(Value = "P1D")]
    P1D,
    [EnumMember(Value = "P1W")]
    P1W,
    [EnumMember(Value = "P1M")]
    P1M,
    [EnumMember(Value = "P3M")]
    P3M,
    [EnumMember(Value = "P1Y")]
    P1Y,
    [EnumMember(Value = "1969-12-28T00:00:00Z/P1W")]
    OneNineSixNineOneTwoTwoEightT000000ZP1W,
    [EnumMember(Value = "1969-12-29T00:00:00Z/P1W")]
    OneNineSixNineOneTwoTwoNineT000000ZP1W,
    [EnumMember(Value = "P1W/1970-01-03T00:00:00Z")]
    P1W19700103T000000Z,
    [EnumMember(Value = "P1W/1970-01-04T00:00:00Z")]
    P1W19700104T000000Z,
}
