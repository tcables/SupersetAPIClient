using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Opacity of layer</summary>
public enum AnnotationLayer_opacity
{
    [EnumMember(Value = "opacityLow")]
    OpacityLow,
    [EnumMember(Value = "opacityMedium")]
    OpacityMedium,
    [EnumMember(Value = "opacityHigh")]
    OpacityHigh,
}
