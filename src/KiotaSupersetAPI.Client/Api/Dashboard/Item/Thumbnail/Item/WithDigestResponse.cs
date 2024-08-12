
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Thumbnail.Item;

[Obsolete("This class is obsolete. Use WithDigestGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithDigestResponse : Dashboard.Item.Thumbnail.Item.WithDigestGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Thumbnail.Item.WithDigestResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Thumbnail.Item.WithDigestResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Thumbnail.Item.WithDigestResponse();
    }
}
