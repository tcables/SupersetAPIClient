using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>The recipient type, check spec for valid options</summary>
public enum ReportRecipient_type
{
    [EnumMember(Value = "Email")]
    Email,
    [EnumMember(Value = "Slack")]
    Slack,
}
