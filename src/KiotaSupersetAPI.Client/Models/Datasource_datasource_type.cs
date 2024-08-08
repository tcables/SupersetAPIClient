using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The type of dataset/datasource identified on `datasource_id`.</summary>
public enum Datasource_datasource_type
{
    [EnumMember(Value = "sl_table")]
#pragma warning disable CS1591
    Sl_table,
#pragma warning restore CS1591
    [EnumMember(Value = "table")]
#pragma warning disable CS1591
    Table,
#pragma warning restore CS1591
    [EnumMember(Value = "dataset")]
#pragma warning disable CS1591
    Dataset,
#pragma warning restore CS1591
    [EnumMember(Value = "query")]
#pragma warning disable CS1591
    Query,
#pragma warning restore CS1591
    [EnumMember(Value = "saved_query")]
#pragma warning disable CS1591
    Saved_query,
#pragma warning restore CS1591
    [EnumMember(Value = "view")]
#pragma warning disable CS1591
    View,
#pragma warning restore CS1591
}
