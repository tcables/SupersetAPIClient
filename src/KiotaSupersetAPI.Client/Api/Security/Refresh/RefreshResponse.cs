
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Refresh;

[Obsolete("This class is obsolete. Use RefreshPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class RefreshResponse : Security.Refresh.RefreshPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Security.Refresh.RefreshResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Refresh.RefreshResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Refresh.RefreshResponse();
    }
}
