
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class ChartDataQueryContextSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Override the default cache timeout</summary>
    public int? CustomCacheTimeout { get; set; }
    /// <summary>The datasource property</summary>
    public Models.ChartDataDatasource Datasource { get; set; }

    /// <summary>Should the queries be forced to load from the source. Default: `false`</summary>
    public bool? Force { get; set; }
    /// <summary>The form_data property</summary>
    public UntypedNode FormData { get; set; }

    /// <summary>The queries property</summary>
    public List<Models.ChartDataQueryObject> Queries { get; set; }

    /// <summary>The result_format property</summary>
    public Models.ChartDataQueryContextSchema_result_format? ResultFormat { get; set; }
    /// <summary>The result_type property</summary>
    public Models.ChartDataQueryContextSchema_result_type? ResultType { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.ChartDataQueryContextSchema"/> and sets the default values.
    /// </summary>
    public ChartDataQueryContextSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ChartDataQueryContextSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ChartDataQueryContextSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ChartDataQueryContextSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "custom_cache_timeout", n => { CustomCacheTimeout = n.GetIntValue(); } },
            { "datasource", n => { Datasource = n.GetObjectValue<Models.ChartDataDatasource>(Models.ChartDataDatasource.CreateFromDiscriminatorValue); } },
            { "force", n => { Force = n.GetBoolValue(); } },
            { "form_data", n => { FormData = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "queries", n => { Queries = n.GetCollectionOfObjectValues<Models.ChartDataQueryObject>(Models.ChartDataQueryObject.CreateFromDiscriminatorValue)?.ToList(); } },
            { "result_format", n => { ResultFormat = n.GetEnumValue<Models.ChartDataQueryContextSchema_result_format>(); } },
            { "result_type", n => { ResultType = n.GetEnumValue<Models.ChartDataQueryContextSchema_result_type>(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("custom_cache_timeout", CustomCacheTimeout);
        writer.WriteObjectValue<Models.ChartDataDatasource>("datasource", Datasource);
        writer.WriteBoolValue("force", Force);
        writer.WriteObjectValue<UntypedNode>("form_data", FormData);
        writer.WriteCollectionOfObjectValues<Models.ChartDataQueryObject>("queries", Queries);
        writer.WriteEnumValue<Models.ChartDataQueryContextSchema_result_format>("result_format", ResultFormat);
        writer.WriteEnumValue<Models.ChartDataQueryContextSchema_result_type>("result_type", ResultType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
