using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public enum QueryExecutionResponseSchema410Error_errors_level
#pragma warning restore CS1591
{
    [EnumMember(Value = "info")]
#pragma warning disable CS1591
    Info,
#pragma warning restore CS1591
    [EnumMember(Value = "warning")]
#pragma warning disable CS1591
    Warning,
#pragma warning restore CS1591
    [EnumMember(Value = "error")]
#pragma warning disable CS1591
    Error,
#pragma warning restore CS1591
}
