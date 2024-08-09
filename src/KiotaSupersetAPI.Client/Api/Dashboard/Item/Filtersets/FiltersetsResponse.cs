
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Filtersets;

[Obsolete("This class is obsolete. Use FiltersetsPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class FiltersetsResponse : Dashboard.Item.Filtersets.FiltersetsPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filtersets.FiltersetsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Dashboard.Item.Filtersets.FiltersetsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dashboard.Item.Filtersets.FiltersetsResponse();
    }
}
