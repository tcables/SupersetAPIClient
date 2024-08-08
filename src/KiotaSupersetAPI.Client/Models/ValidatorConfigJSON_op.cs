
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>The operation to compare with a threshold to apply to the SQL output</summary>
    public enum ValidatorConfigJSON_op
    {
        [EnumMember(Value = "<")]
        #pragma warning disable CS1591
        LessThan,
        #pragma warning restore CS1591
        [EnumMember(Value = "<=")]
        #pragma warning disable CS1591
        LessThanEqual,
        #pragma warning restore CS1591
        [EnumMember(Value = ">")]
        #pragma warning disable CS1591
        GreaterThan,
        #pragma warning restore CS1591
        [EnumMember(Value = ">=")]
        #pragma warning disable CS1591
        GreaterThanEqual,
        #pragma warning restore CS1591
        [EnumMember(Value = "==")]
        #pragma warning disable CS1591
        EqualEqual,
        #pragma warning restore CS1591
        [EnumMember(Value = "!=")]
        #pragma warning disable CS1591
        ExclamationEqual,
        #pragma warning restore CS1591
    }
}
