using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Type of source for annotation data</summary>
public enum AnnotationLayer_sourceType
{
    [EnumMember(Value = "line")]
    Line,
    [EnumMember(Value = "NATIVE")]
    NATIVE,
    [EnumMember(Value = "table")]
    Table,
}
