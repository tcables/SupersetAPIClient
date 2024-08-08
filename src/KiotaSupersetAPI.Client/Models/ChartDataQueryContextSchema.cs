
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class ChartDataQueryContextSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Override the default cache timeout</summary>
    public int? CustomCacheTimeout { get; set; }
    /// <summary>The datasource property</summary>
    public KClient.Models.ChartDataDatasource Datasource { get; set; }

    /// <summary>Should the queries be forced to load from the source. Default: `false`</summary>
    public bool? Force { get; set; }
    /// <summary>The form_data property</summary>
    public UntypedNode FormData { get; set; }

    /// <summary>The queries property</summary>
    public List<KClient.Models.ChartDataQueryObject> Queries { get; set; }

    /// <summary>The result_format property</summary>
    public KClient.Models.ChartDataQueryContextSchema_result_format? ResultFormat { get; set; }
    /// <summary>The result_type property</summary>
    public KClient.Models.ChartDataQueryContextSchema_result_type? ResultType { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartDataQueryContextSchema"/> and sets the default values.
    /// </summary>
    public ChartDataQueryContextSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartDataQueryContextSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartDataQueryContextSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartDataQueryContextSchema();
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
            { "datasource", n => { Datasource = n.GetObjectValue<KClient.Models.ChartDataDatasource>(KClient.Models.ChartDataDatasource.CreateFromDiscriminatorValue); } },
            { "force", n => { Force = n.GetBoolValue(); } },
            { "form_data", n => { FormData = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "queries", n => { Queries = n.GetCollectionOfObjectValues<KClient.Models.ChartDataQueryObject>(KClient.Models.ChartDataQueryObject.CreateFromDiscriminatorValue)?.ToList(); } },
            { "result_format", n => { ResultFormat = n.GetEnumValue<KClient.Models.ChartDataQueryContextSchema_result_format>(); } },
            { "result_type", n => { ResultType = n.GetEnumValue<KClient.Models.ChartDataQueryContextSchema_result_type>(); } },
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
        writer.WriteObjectValue<KClient.Models.ChartDataDatasource>("datasource", Datasource);
        writer.WriteBoolValue("force", Force);
        writer.WriteObjectValue<UntypedNode>("form_data", FormData);
        writer.WriteCollectionOfObjectValues<KClient.Models.ChartDataQueryObject>("queries", Queries);
        writer.WriteEnumValue<KClient.Models.ChartDataQueryContextSchema_result_format>("result_format", ResultFormat);
        writer.WriteEnumValue<KClient.Models.ChartDataQueryContextSchema_result_type>("result_type", ResultType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
