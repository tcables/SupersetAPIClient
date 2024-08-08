using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public enum ChartDataQueryContextSchema_result_format
#pragma warning restore CS1591
{
    [EnumMember(Value = "csv")]
#pragma warning disable CS1591
    Csv,
#pragma warning restore CS1591
    [EnumMember(Value = "json")]
#pragma warning disable CS1591
    Json,
#pragma warning restore CS1591
    [EnumMember(Value = "xlsx")]
#pragma warning disable CS1591
    Xlsx,
#pragma warning restore CS1591
}
