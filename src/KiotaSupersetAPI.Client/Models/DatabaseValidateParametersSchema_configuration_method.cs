
using System;
using System.CodeDom.Compiler;
using System.Linq;
using System.Runtime.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Configuration_method is used on the frontend to inform the backend whether to explode parameters or to provide only a sqlalchemy_uri.</summary>
public enum DatabaseValidateParametersSchema_configuration_method
{
    [EnumMember(Value = "sqlalchemy_form")]
#pragma warning disable CS1591
    Sqlalchemy_form,
#pragma warning restore CS1591
    [EnumMember(Value = "dynamic_form")]
#pragma warning disable CS1591
    Dynamic_form,
#pragma warning restore CS1591
}
