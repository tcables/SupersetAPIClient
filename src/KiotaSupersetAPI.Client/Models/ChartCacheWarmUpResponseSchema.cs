
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartCacheWarmUpResponseSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>A list of each chart&apos;s warmup status and errors if any</summary>
    public List<KClient.Models.ChartCacheWarmUpResponseSingle> Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartCacheWarmUpResponseSchema"/> and sets the default values.
    /// </summary>
    public ChartCacheWarmUpResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartCacheWarmUpResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartCacheWarmUpResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartCacheWarmUpResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "result", n => { Result = n.GetCollectionOfObjectValues<KClient.Models.ChartCacheWarmUpResponseSingle>(KClient.Models.ChartCacheWarmUpResponseSingle.CreateFromDiscriminatorValue)?.ToList(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfObjectValues<KClient.Models.ChartCacheWarmUpResponseSingle>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
