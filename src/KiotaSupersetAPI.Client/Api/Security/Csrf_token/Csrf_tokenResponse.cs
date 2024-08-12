
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Csrf_token;

[Obsolete("This class is obsolete. Use Csrf_tokenGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Csrf_tokenResponse : Security.Csrf_token.Csrf_tokenGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Security.Csrf_token.Csrf_tokenResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Csrf_token.Csrf_tokenResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Csrf_token.Csrf_tokenResponse();
    }
}
