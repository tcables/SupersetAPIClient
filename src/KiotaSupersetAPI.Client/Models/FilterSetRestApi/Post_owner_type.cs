
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.FilterSetRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public enum Post_owner_type
#pragma warning restore CS1591
{
    [EnumMember(Value = "User")]
#pragma warning disable CS1591
    User,
#pragma warning restore CS1591
    [EnumMember(Value = "Dashboard")]
#pragma warning disable CS1591
    Dashboard,
#pragma warning restore CS1591
}
