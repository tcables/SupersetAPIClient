using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Status of the query</summary>
public enum ChartDataResponseResult_status
{
    [EnumMember(Value = "stopped")]
    Stopped,
    [EnumMember(Value = "failed")]
    Failed,
    [EnumMember(Value = "pending")]
    Pending,
    [EnumMember(Value = "running")]
    Running,
    [EnumMember(Value = "scheduled")]
    Scheduled,
    [EnumMember(Value = "success")]
    Success,
    [EnumMember(Value = "timed_out")]
    Timed_out,
}
