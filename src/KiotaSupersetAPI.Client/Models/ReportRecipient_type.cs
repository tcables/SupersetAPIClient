
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>The recipient type, check spec for valid options</summary>
    public enum ReportRecipient_type
    {
        [EnumMember(Value = "Email")]
        #pragma warning disable CS1591
        Email,
        #pragma warning restore CS1591
        [EnumMember(Value = "Slack")]
        #pragma warning disable CS1591
        Slack,
        #pragma warning restore CS1591
    }
}
