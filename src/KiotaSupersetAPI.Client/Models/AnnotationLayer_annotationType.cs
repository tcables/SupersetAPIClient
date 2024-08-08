
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>Type of annotation layer</summary>
    public enum AnnotationLayer_annotationType
    {
        [EnumMember(Value = "FORMULA")]
        #pragma warning disable CS1591
        FORMULA,
        #pragma warning restore CS1591
        [EnumMember(Value = "INTERVAL")]
        #pragma warning disable CS1591
        INTERVAL,
        #pragma warning restore CS1591
        [EnumMember(Value = "EVENT")]
        #pragma warning disable CS1591
        EVENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "TIME_SERIES")]
        #pragma warning disable CS1591
        TIME_SERIES,
        #pragma warning restore CS1591
    }
}
