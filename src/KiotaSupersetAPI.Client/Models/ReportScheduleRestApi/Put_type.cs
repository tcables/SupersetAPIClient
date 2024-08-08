
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestApi
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>The report schedule type</summary>
    public enum Put_type
    {
        [EnumMember(Value = "Alert")]
        #pragma warning disable CS1591
        Alert,
        #pragma warning restore CS1591
        [EnumMember(Value = "Report")]
        #pragma warning disable CS1591
        Report,
        #pragma warning restore CS1591
    }
}
