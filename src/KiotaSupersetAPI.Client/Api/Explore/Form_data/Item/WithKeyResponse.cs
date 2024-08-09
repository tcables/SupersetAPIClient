
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Explore.Form_data.Item;

[Obsolete("This class is obsolete. Use WithKeyDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyResponse : Explore.Form_data.Item.WithKeyDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Explore.Form_data.Item.WithKeyResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Explore.Form_data.Item.WithKeyResponse();
    }
}
