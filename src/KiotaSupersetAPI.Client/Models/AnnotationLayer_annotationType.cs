using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Type of annotation layer</summary>
public enum AnnotationLayer_annotationType
{
    [EnumMember(Value = "FORMULA")]
    FORMULA,
    [EnumMember(Value = "INTERVAL")]
    INTERVAL,
    [EnumMember(Value = "EVENT")]
    EVENT,
    [EnumMember(Value = "TIME_SERIES")]
    TIME_SERIES,
}
