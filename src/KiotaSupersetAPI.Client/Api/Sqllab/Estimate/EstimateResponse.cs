
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Sqllab.Estimate;

[Obsolete("This class is obsolete. Use EstimatePostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class EstimateResponse : Sqllab.Estimate.EstimatePostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Sqllab.Estimate.EstimateResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Sqllab.Estimate.EstimateResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Sqllab.Estimate.EstimateResponse();
    }
}
