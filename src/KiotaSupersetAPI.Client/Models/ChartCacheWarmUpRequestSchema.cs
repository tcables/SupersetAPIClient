
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class ChartCacheWarmUpRequestSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The ID of the chart to warm up cache for</summary>
    public int? ChartId { get; set; }
    /// <summary>The ID of the dashboard to get filters for when warming cache</summary>
    public int? DashboardId { get; set; }
    /// <summary>Extra filters to apply when warming up cache</summary>
    public string ExtraFilters { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartCacheWarmUpRequestSchema"/> and sets the default values.
    /// </summary>
    public ChartCacheWarmUpRequestSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartCacheWarmUpRequestSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartCacheWarmUpRequestSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartCacheWarmUpRequestSchema();
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
            { "dashboard_id", n => { DashboardId = n.GetIntValue(); } },
            { "extra_filters", n => { ExtraFilters = n.GetStringValue(); } },
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
        writer.WriteIntValue("dashboard_id", DashboardId);
        writer.WriteStringValue("extra_filters", ExtraFilters);
        writer.WriteAdditionalData(AdditionalData);
    }
}
