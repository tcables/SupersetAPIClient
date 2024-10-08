
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Embedded_dashboard.Item;

[Obsolete("This class is obsolete. Use WithUuGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithUuResponse : Embedded_dashboard.Item.WithUuGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Embedded_dashboard.Item.WithUuResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Embedded_dashboard.Item.WithUuResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Embedded_dashboard.Item.WithUuResponse();
    }
}
