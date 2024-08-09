using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The operation to compare with a threshold to apply to the SQL output</summary>
public enum ValidatorConfigJSON_op
{
    [EnumMember(Value = "<")]
    LessThan,
    [EnumMember(Value = "<=")]
    LessThanEqual,
    [EnumMember(Value = ">")]
    GreaterThan,
    [EnumMember(Value = ">=")]
    GreaterThanEqual,
    [EnumMember(Value = "==")]
    EqualEqual,
    [EnumMember(Value = "!=")]
    ExclamationEqual,
}
