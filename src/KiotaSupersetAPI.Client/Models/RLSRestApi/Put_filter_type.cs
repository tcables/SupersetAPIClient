
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.RLSRestApi
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>filter_type_description</summary>
    public enum Put_filter_type
    {
        [EnumMember(Value = "Regular")]
        #pragma warning disable CS1591
        Regular,
        #pragma warning restore CS1591
        [EnumMember(Value = "Base")]
        #pragma warning disable CS1591
        Base,
        #pragma warning restore CS1591
    }
}
