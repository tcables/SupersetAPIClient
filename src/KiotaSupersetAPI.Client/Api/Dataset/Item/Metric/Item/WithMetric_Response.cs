
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Item.Metric.Item;

[Obsolete("This class is obsolete. Use WithMetric_DeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithMetric_Response : Dataset.Item.Metric.Item.WithMetric_DeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dataset.Item.Metric.Item.WithMetric_Response"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Dataset.Item.Metric.Item.WithMetric_Response CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dataset.Item.Metric.Item.WithMetric_Response();
    }
}
