using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Line style. Only applies to time-series annotations</summary>
public enum AnnotationLayer_style
{
    [EnumMember(Value = "dashed")]
    Dashed,
    [EnumMember(Value = "dotted")]
    Dotted,
    [EnumMember(Value = "solid")]
    Solid,
    [EnumMember(Value = "longDashed")]
    LongDashed,
}
