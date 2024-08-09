using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The report schedule type</summary>
public enum Post_type
{
    [EnumMember(Value = "Alert")]
    Alert,
    [EnumMember(Value = "Report")]
    Report,
}
