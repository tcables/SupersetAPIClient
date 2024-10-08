
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Permalink.Item;

[Obsolete("This class is obsolete. Use WithKeyGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyResponse : Dashboard.Permalink.Item.WithKeyGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Permalink.Item.WithKeyResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Permalink.Item.WithKeyResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Permalink.Item.WithKeyResponse();
    }
}
