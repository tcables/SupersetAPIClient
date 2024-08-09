
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Charts;

[Obsolete("This class is obsolete. Use ChartsGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartsResponse : Dashboard.Item.Charts.ChartsGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Charts.ChartsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Dashboard.Item.Charts.ChartsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dashboard.Item.Charts.ChartsResponse();
    }
}
