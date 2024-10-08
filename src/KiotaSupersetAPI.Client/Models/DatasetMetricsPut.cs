
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatasetMetricsPut : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The currency property</summary>
    public string Currency { get; set; }

    /// <summary>The d3format property</summary>
    public string D3format { get; set; }

    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The expression property</summary>
    public string Expression { get; set; }

    /// <summary>The extra property</summary>
    public string Extra { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The metric_name property</summary>
    public string MetricName { get; set; }

    /// <summary>The metric_type property</summary>
    public string MetricType { get; set; }

    /// <summary>The uuid property</summary>
    public Guid? Uuid { get; set; }
    /// <summary>The verbose_name property</summary>
    public string VerboseName { get; set; }

    /// <summary>The warning_text property</summary>
    public string WarningText { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatasetMetricsPut"/> and sets the default values.
    /// </summary>
    public DatasetMetricsPut()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatasetMetricsPut"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatasetMetricsPut CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatasetMetricsPut();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "currency", n => { Currency = n.GetStringValue(); } },
            { "d3format", n => { D3format = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "expression", n => { Expression = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "metric_name", n => { MetricName = n.GetStringValue(); } },
            { "metric_type", n => { MetricType = n.GetStringValue(); } },
            { "uuid", n => { Uuid = n.GetGuidValue(); } },
            { "verbose_name", n => { VerboseName = n.GetStringValue(); } },
            { "warning_text", n => { WarningText = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("currency", Currency);
        writer.WriteStringValue("d3format", D3format);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("expression", Expression);
        writer.WriteStringValue("extra", Extra);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("metric_name", MetricName);
        writer.WriteStringValue("metric_type", MetricType);
        writer.WriteGuidValue("uuid", Uuid);
        writer.WriteStringValue("verbose_name", VerboseName);
        writer.WriteStringValue("warning_text", WarningText);
        writer.WriteAdditionalData(AdditionalData);
    }
}
