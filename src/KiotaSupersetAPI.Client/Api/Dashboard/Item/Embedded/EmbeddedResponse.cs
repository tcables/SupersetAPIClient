
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Embedded;

[Obsolete("This class is obsolete. Use EmbeddedDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class EmbeddedResponse : Dashboard.Item.Embedded.EmbeddedDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Embedded.EmbeddedResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Item.Embedded.EmbeddedResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Embedded.EmbeddedResponse();
    }
}
