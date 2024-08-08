
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DatasetCacheWarmUpResponseSingle : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The ID of the chart the status belongs to</summary>
    public int? ChartId { get; set; }
    /// <summary>Error that occurred when warming cache for chart</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? VizError { get; set; }
#nullable restore
#else
    public string VizError { get; set; }
#endif
    /// <summary>Status of the underlying query for the viz</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? VizStatus { get; set; }
#nullable restore
#else
    public string VizStatus { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatasetCacheWarmUpResponseSingle"/> and sets the default values.
    /// </summary>
    public DatasetCacheWarmUpResponseSingle()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetCacheWarmUpResponseSingle"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatasetCacheWarmUpResponseSingle CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatasetCacheWarmUpResponseSingle();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "chart_id", n => { ChartId = n.GetIntValue(); } },
            { "viz_error", n => { VizError = n.GetStringValue(); } },
            { "viz_status", n => { VizStatus = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("chart_id", ChartId);
        writer.WriteStringValue("viz_error", VizError);
        writer.WriteStringValue("viz_status", VizStatus);
        writer.WriteAdditionalData(AdditionalData);
    }
}
