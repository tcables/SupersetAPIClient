using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Creation method is used to inform the frontend whether the report/alert was created in the dashboard, chart, or alerts and reports UI.</summary>
public enum Put_creation_method
{
    [EnumMember(Value = "charts")]
    Charts,
    [EnumMember(Value = "dashboards")]
    Dashboards,
    [EnumMember(Value = "alerts_reports")]
    Alerts_reports,
}
