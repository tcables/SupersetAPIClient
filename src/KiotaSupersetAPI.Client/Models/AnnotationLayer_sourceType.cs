using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Type of source for annotation data</summary>
public enum AnnotationLayer_sourceType
{
    [EnumMember(Value = "line")]
#pragma warning disable CS1591
    Line,
#pragma warning restore CS1591
    [EnumMember(Value = "NATIVE")]
#pragma warning disable CS1591
    NATIVE,
#pragma warning restore CS1591
    [EnumMember(Value = "table")]
#pragma warning disable CS1591
    Table,
#pragma warning restore CS1591
}
