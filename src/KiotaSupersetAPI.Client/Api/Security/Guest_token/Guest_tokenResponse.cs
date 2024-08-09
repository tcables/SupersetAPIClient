
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Guest_token;

[Obsolete("This class is obsolete. Use Guest_tokenPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Guest_tokenResponse : Security.Guest_token.Guest_tokenPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Security.Guest_token.Guest_tokenResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Security.Guest_token.Guest_tokenResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Security.Guest_token.Guest_tokenResponse();
    }
}
