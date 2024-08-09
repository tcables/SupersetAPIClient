
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Sqllab.Estimate;

[Obsolete("This class is obsolete. Use EstimatePostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class EstimateResponse : KApi.Sqllab.Estimate.EstimatePostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Sqllab.Estimate.EstimateResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Sqllab.Estimate.EstimateResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Sqllab.Estimate.EstimateResponse();
    }
}
