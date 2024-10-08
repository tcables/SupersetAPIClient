using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models.ReportScheduleRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Determines when to trigger alert based off value from alert query. Alerts will be triggered with these validator types:- Not Null - When the return value is Not NULL, Empty, or 0- Operator - When `sql_return_value comparison_operator threshold` is True e.g. `50 &lt;= 75`&lt;br&gt;Supports the comparison operators &lt;, &lt;=, &gt;, &gt;=, ==, and !=</summary>
public enum Post_validator_type
{
    [EnumMember(Value = "not null")]
    NotNull,
    [EnumMember(Value = "operator")]
    Operator,
}
