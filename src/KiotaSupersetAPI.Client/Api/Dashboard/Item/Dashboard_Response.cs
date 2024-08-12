
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item;

[Obsolete("This class is obsolete. Use Dashboard_GetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Dashboard_Response : Dashboard.Item.Dashboard_GetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_Response"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Item.Dashboard_Response CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Dashboard_Response();
    }
}
