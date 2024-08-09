using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public enum ChartDataQueryContextSchema_result_type
{
    [EnumMember(Value = "columns")]
    Columns,
    [EnumMember(Value = "full")]
    Full,
    [EnumMember(Value = "query")]
    Query,
    [EnumMember(Value = "results")]
    Results,
    [EnumMember(Value = "samples")]
    Samples,
    [EnumMember(Value = "timegrains")]
    Timegrains,
    [EnumMember(Value = "post_processed")]
    Post_processed,
    [EnumMember(Value = "drill_detail")]
    Drill_detail,
}
