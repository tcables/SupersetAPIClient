using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public enum ChartDataQueryContextSchema_result_format
{
    [EnumMember(Value = "csv")]
    Csv,
    [EnumMember(Value = "json")]
    Json,
    [EnumMember(Value = "xlsx")]
    Xlsx,
}
