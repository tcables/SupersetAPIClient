
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public enum Post_report_format
#pragma warning restore CS1591
{
    [EnumMember(Value = "PNG")]
#pragma warning disable CS1591
    PNG,
#pragma warning restore CS1591
    [EnumMember(Value = "CSV")]
#pragma warning disable CS1591
    CSV,
#pragma warning restore CS1591
    [EnumMember(Value = "TEXT")]
#pragma warning disable CS1591
    TEXT,
#pragma warning restore CS1591
}
