using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models.DatabaseRestApi;

[GeneratedCode("Kiota", "1.16.0")]
/// <summary>Configuration_method is used on the frontend to inform the backend whether to explode parameters or to provide only a sqlalchemy_uri.</summary>
public enum Post_configuration_method
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
