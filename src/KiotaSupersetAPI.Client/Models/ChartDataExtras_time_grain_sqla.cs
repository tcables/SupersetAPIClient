
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>To what level of granularity should the temporal column be aggregated. Supports [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601#Durations) durations.</summary>
    public enum ChartDataExtras_time_grain_sqla
    {
        [EnumMember(Value = "PT1S")]
        #pragma warning disable CS1591
        PT1S,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT5S")]
        #pragma warning disable CS1591
        PT5S,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT30S")]
        #pragma warning disable CS1591
        PT30S,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT1M")]
        #pragma warning disable CS1591
        PT1M,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT5M")]
        #pragma warning disable CS1591
        PT5M,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT10M")]
        #pragma warning disable CS1591
        PT10M,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT15M")]
        #pragma warning disable CS1591
        PT15M,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT30M")]
        #pragma warning disable CS1591
        PT30M,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT1H")]
        #pragma warning disable CS1591
        PT1H,
        #pragma warning restore CS1591
        [EnumMember(Value = "PT6H")]
        #pragma warning disable CS1591
        PT6H,
        #pragma warning restore CS1591
        [EnumMember(Value = "P1D")]
        #pragma warning disable CS1591
        P1D,
        #pragma warning restore CS1591
        [EnumMember(Value = "P1W")]
        #pragma warning disable CS1591
        P1W,
        #pragma warning restore CS1591
        [EnumMember(Value = "P1M")]
        #pragma warning disable CS1591
        P1M,
        #pragma warning restore CS1591
        [EnumMember(Value = "P3M")]
        #pragma warning disable CS1591
        P3M,
        #pragma warning restore CS1591
        [EnumMember(Value = "P1Y")]
        #pragma warning disable CS1591
        P1Y,
        #pragma warning restore CS1591
        [EnumMember(Value = "1969-12-28T00:00:00Z/P1W")]
        #pragma warning disable CS1591
        OneNineSixNineOneTwoTwoEightT000000ZP1W,
        #pragma warning restore CS1591
        [EnumMember(Value = "1969-12-29T00:00:00Z/P1W")]
        #pragma warning disable CS1591
        OneNineSixNineOneTwoTwoNineT000000ZP1W,
        #pragma warning restore CS1591
        [EnumMember(Value = "P1W/1970-01-03T00:00:00Z")]
        #pragma warning disable CS1591
        P1W19700103T000000Z,
        #pragma warning restore CS1591
        [EnumMember(Value = "P1W/1970-01-04T00:00:00Z")]
        #pragma warning disable CS1591
        P1W19700104T000000Z,
        #pragma warning restore CS1591
    }
}
