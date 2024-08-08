
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Creation method is used to inform the frontend whether the report/alert was created in the dashboard, chart, or alerts and reports UI.</summary>
public enum Post_creation_method
{
    [EnumMember(Value = "charts")]
#pragma warning disable CS1591
    Charts,
#pragma warning restore CS1591
    [EnumMember(Value = "dashboards")]
#pragma warning disable CS1591
    Dashboards,
#pragma warning restore CS1591
    [EnumMember(Value = "alerts_reports")]
#pragma warning disable CS1591
    Alerts_reports,
#pragma warning restore CS1591
}
