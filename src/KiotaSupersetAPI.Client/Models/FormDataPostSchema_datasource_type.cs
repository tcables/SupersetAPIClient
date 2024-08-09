using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The datasource type</summary>
public enum FormDataPostSchema_datasource_type
{
    [EnumMember(Value = "sl_table")]
    Sl_table,
    [EnumMember(Value = "table")]
    Table,
    [EnumMember(Value = "dataset")]
    Dataset,
    [EnumMember(Value = "query")]
    Query,
    [EnumMember(Value = "saved_query")]
    Saved_query,
    [EnumMember(Value = "view")]
    View,
}
