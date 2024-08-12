
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Item;

[Obsolete("This class is obsolete. Use Object_typeDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Object_typeResponse : Tag.Item.Object_typeDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Tag.Item.Object_typeResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Object_typeResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Object_typeResponse();
    }
}
