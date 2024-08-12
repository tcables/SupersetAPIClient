
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Log.Item;

[Obsolete("This class is obsolete. Use WithPkGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkResponse : KiotaSupersetAPI.Client.API.Log.Item.WithPkGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="API.Log.Item.WithPkResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Log.Item.WithPkResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Log.Item.WithPkResponse();
    }
}
