
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Sqllab.Estimate;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class EstimatePostResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.Sqllab.Estimate.EstimatePostResponse_result? Result { get; set; }
#nullable restore
#else
    public KApi.Sqllab.Estimate.EstimatePostResponse_result Result { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.Sqllab.Estimate.EstimatePostResponse"/> and sets the default values.
    /// </summary>
    public EstimatePostResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Sqllab.Estimate.EstimatePostResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Sqllab.Estimate.EstimatePostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Sqllab.Estimate.EstimatePostResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "result", n => { Result = n.GetObjectValue<KApi.Sqllab.Estimate.EstimatePostResponse_result>(KApi.Sqllab.Estimate.EstimatePostResponse_result.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KApi.Sqllab.Estimate.EstimatePostResponse_result>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
