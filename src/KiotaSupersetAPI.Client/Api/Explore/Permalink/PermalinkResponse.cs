
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Explore.Permalink;

[Obsolete("This class is obsolete. Use PermalinkPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class PermalinkResponse : Explore.Permalink.PermalinkPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Explore.Permalink.PermalinkResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Permalink.PermalinkResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Permalink.PermalinkResponse();
    }
}
