using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi;

[GeneratedCode("Kiota", "1.16.0")]
public enum Post_report_format
{
    [EnumMember(Value = "PNG")]
    PNG,
    [EnumMember(Value = "CSV")]
    CSV,
    [EnumMember(Value = "TEXT")]
    TEXT,
}
