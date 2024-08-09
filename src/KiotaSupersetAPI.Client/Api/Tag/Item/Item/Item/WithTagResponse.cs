
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Tag.Item.Item.Item;

[Obsolete("This class is obsolete. Use WithTagDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithTagResponse : KApi.Tag.Item.Item.Item.WithTagDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Item.Item.Item.WithTagResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Tag.Item.Item.Item.WithTagResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Tag.Item.Item.Item.WithTagResponse();
    }
}
