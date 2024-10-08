
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartDataExtras : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>HAVING clause to be added to aggregate queries using AND operator.</summary>
    public string Having { get; set; }

    /// <summary>End time for relative time deltas. Default: `config[&quot;DEFAULT_RELATIVE_START_TIME&quot;]`</summary>
    public Models.ChartDataExtras_relative_end? RelativeEnd { get; set; }
    /// <summary>Start time for relative time deltas. Default: `config[&quot;DEFAULT_RELATIVE_START_TIME&quot;]`</summary>
    public Models.ChartDataExtras_relative_start? RelativeStart { get; set; }
    /// <summary>To what level of granularity should the temporal column be aggregated. Supports [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601#Durations) durations.</summary>
    public Models.ChartDataExtras_time_grain_sqla? TimeGrainSqla { get; set; }
    /// <summary>WHERE clause to be added to queries using AND operator.</summary>
    public string Where { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ChartDataExtras"/> and sets the default values.
    /// </summary>
    public ChartDataExtras()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ChartDataExtras"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ChartDataExtras CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ChartDataExtras();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "having", n => { Having = n.GetStringValue(); } },
            { "relative_end", n => { RelativeEnd = n.GetEnumValue<Models.ChartDataExtras_relative_end>(); } },
            { "relative_start", n => { RelativeStart = n.GetEnumValue<Models.ChartDataExtras_relative_start>(); } },
            { "time_grain_sqla", n => { TimeGrainSqla = n.GetEnumValue<Models.ChartDataExtras_time_grain_sqla>(); } },
            { "where", n => { Where = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("having", Having);
        writer.WriteEnumValue<Models.ChartDataExtras_relative_end>("relative_end", RelativeEnd);
        writer.WriteEnumValue<Models.ChartDataExtras_relative_start>("relative_start", RelativeStart);
        writer.WriteEnumValue<Models.ChartDataExtras_time_grain_sqla>("time_grain_sqla", TimeGrainSqla);
        writer.WriteStringValue("where", Where);
        writer.WriteAdditionalData(AdditionalData);
    }
}
