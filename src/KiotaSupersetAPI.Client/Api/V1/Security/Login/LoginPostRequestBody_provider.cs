
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Security.Login
{
    [GeneratedCode("Kiota", "1.16.0")]
    /// <summary>Choose an authentication provider</summary>
    public enum LoginPostRequestBody_provider
    {
        [EnumMember(Value = "db")]
        #pragma warning disable CS1591
        Db,
        #pragma warning restore CS1591
        [EnumMember(Value = "ldap")]
        #pragma warning disable CS1591
        Ldap,
        #pragma warning restore CS1591
    }
}
