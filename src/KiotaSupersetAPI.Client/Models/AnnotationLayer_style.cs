
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Line style. Only applies to time-series annotations</summary>
public enum AnnotationLayer_style
{
    [EnumMember(Value = "dashed")]
#pragma warning disable CS1591
    Dashed,
#pragma warning restore CS1591
    [EnumMember(Value = "dotted")]
#pragma warning disable CS1591
    Dotted,
#pragma warning restore CS1591
    [EnumMember(Value = "solid")]
#pragma warning disable CS1591
    Solid,
#pragma warning restore CS1591
    [EnumMember(Value = "longDashed")]
#pragma warning disable CS1591
    LongDashed,
#pragma warning restore CS1591
}
