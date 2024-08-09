using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The report schedule type</summary>
public enum Put_type
{
    [EnumMember(Value = "Alert")]
    Alert,
    [EnumMember(Value = "Report")]
    Report,
}
