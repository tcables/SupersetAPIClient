using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Login;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Choose an authentication provider</summary>
public enum LoginPostRequestBody_provider
{
    [EnumMember(Value = "db")]
    Db,
    [EnumMember(Value = "ldap")]
    Ldap,
}
