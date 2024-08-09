using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Configuration_method is used on the frontend to inform the backend whether to explode parameters or to provide only a sqlalchemy_uri.</summary>
public enum DatabaseTestConnectionSchema_configuration_method
{
    [EnumMember(Value = "sqlalchemy_form")]
    Sqlalchemy_form,
    [EnumMember(Value = "dynamic_form")]
    Dynamic_form,
}
