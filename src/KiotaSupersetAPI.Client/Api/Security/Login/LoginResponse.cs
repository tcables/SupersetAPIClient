
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Login;

[Obsolete("This class is obsolete. Use LoginPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class LoginResponse : Security.Login.LoginPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Security.Login.LoginResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Login.LoginResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Login.LoginResponse();
    }
}
