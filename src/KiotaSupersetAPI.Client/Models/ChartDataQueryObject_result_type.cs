
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public enum ChartDataQueryObject_result_type
#pragma warning restore CS1591
{
    [EnumMember(Value = "columns")]
#pragma warning disable CS1591
    Columns,
#pragma warning restore CS1591
    [EnumMember(Value = "full")]
#pragma warning disable CS1591
    Full,
#pragma warning restore CS1591
    [EnumMember(Value = "query")]
#pragma warning disable CS1591
    Query,
#pragma warning restore CS1591
    [EnumMember(Value = "results")]
#pragma warning disable CS1591
    Results,
#pragma warning restore CS1591
    [EnumMember(Value = "samples")]
#pragma warning disable CS1591
    Samples,
#pragma warning restore CS1591
    [EnumMember(Value = "timegrains")]
#pragma warning disable CS1591
    Timegrains,
#pragma warning restore CS1591
    [EnumMember(Value = "post_processed")]
#pragma warning disable CS1591
    Post_processed,
#pragma warning restore CS1591
    [EnumMember(Value = "drill_detail")]
#pragma warning disable CS1591
    Drill_detail,
#pragma warning restore CS1591
}
