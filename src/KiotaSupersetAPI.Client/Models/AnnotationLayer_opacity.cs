using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Opacity of layer</summary>
public enum AnnotationLayer_opacity
{
    [EnumMember(Value = "opacityLow")]
#pragma warning disable CS1591
    OpacityLow,
#pragma warning restore CS1591
    [EnumMember(Value = "opacityMedium")]
#pragma warning disable CS1591
    OpacityMedium,
#pragma warning restore CS1591
    [EnumMember(Value = "opacityHigh")]
#pragma warning disable CS1591
    OpacityHigh,
#pragma warning restore CS1591
}
