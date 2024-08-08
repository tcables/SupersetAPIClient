
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Status of the query</summary>
public enum ChartDataResponseResult_status
{
    [EnumMember(Value = "stopped")]
#pragma warning disable CS1591
    Stopped,
#pragma warning restore CS1591
    [EnumMember(Value = "failed")]
#pragma warning disable CS1591
    Failed,
#pragma warning restore CS1591
    [EnumMember(Value = "pending")]
#pragma warning disable CS1591
    Pending,
#pragma warning restore CS1591
    [EnumMember(Value = "running")]
#pragma warning disable CS1591
    Running,
#pragma warning restore CS1591
    [EnumMember(Value = "scheduled")]
#pragma warning disable CS1591
    Scheduled,
#pragma warning restore CS1591
    [EnumMember(Value = "success")]
#pragma warning disable CS1591
    Success,
#pragma warning restore CS1591
    [EnumMember(Value = "timed_out")]
#pragma warning disable CS1591
    Timed_out,
#pragma warning restore CS1591
}
