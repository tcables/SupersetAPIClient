
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Item;

[Obsolete("This class is obsolete. Use WithPkDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkResponse : Dataset.Item.WithPkDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dataset.Item.WithPkResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Item.WithPkResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.WithPkResponse();
    }
}
