
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.ChartRestApi;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Post : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Duration (in seconds) of the caching timeout for this chart. Note this defaults to the datasource/table timeout if undefined.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Details of the certification</summary>
    public string CertificationDetails { get; set; }

    /// <summary>Person or group that has certified this chart</summary>
    public string CertifiedBy { get; set; }

    /// <summary>The dashboards property</summary>
    public List<int?> Dashboards { get; set; }

    /// <summary>The id of the dataset/datasource this new chart will use. A complete datasource identification needs `datasource_id` and `datasource_type`.</summary>
    public int? DatasourceId { get; set; }
    /// <summary>The datasource name.</summary>
    public string DatasourceName { get; set; }

    /// <summary>The type of dataset/datasource identified on `datasource_id`.</summary>
    public Models.ChartRestApi.Post_datasource_type? DatasourceType { get; set; }
    /// <summary>A description of the chart propose.</summary>
    public string Description { get; set; }

    /// <summary>The external_url property</summary>
    public string ExternalUrl { get; set; }

    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The owners property</summary>
    public List<int?> Owners { get; set; }

    /// <summary>Parameters are generated dynamically when clicking the save or overwrite button in the explore view. This JSON object for power users who may want to alter specific parameters.</summary>
    public string Params { get; set; }

    /// <summary>The query context represents the queries that need to run in order to generate the data the visualization, and in what format the data should be returned.</summary>
    public string QueryContext { get; set; }

    /// <summary>The query context generation represents whether the query_contextis user generated or not so that it does not update user modifiedstate.</summary>
    public bool? QueryContextGeneration { get; set; }
    /// <summary>The name of the chart.</summary>
    public string SliceName { get; set; }

    /// <summary>The type of chart visualization used.</summary>
    public string VizType { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ChartRestApi.Post"/> and sets the default values.
    /// </summary>
    public Post()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ChartRestApi.Post"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ChartRestApi.Post CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ChartRestApi.Post();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "cache_timeout", n => { CacheTimeout = n.GetIntValue(); } },
            { "certification_details", n => { CertificationDetails = n.GetStringValue(); } },
            { "certified_by", n => { CertifiedBy = n.GetStringValue(); } },
            { "dashboards", n => { Dashboards = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "datasource_id", n => { DatasourceId = n.GetIntValue(); } },
            { "datasource_name", n => { DatasourceName = n.GetStringValue(); } },
            { "datasource_type", n => { DatasourceType = n.GetEnumValue<Models.ChartRestApi.Post_datasource_type>(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "external_url", n => { ExternalUrl = n.GetStringValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "params", n => { Params = n.GetStringValue(); } },
            { "query_context", n => { QueryContext = n.GetStringValue(); } },
            { "query_context_generation", n => { QueryContextGeneration = n.GetBoolValue(); } },
            { "slice_name", n => { SliceName = n.GetStringValue(); } },
            { "viz_type", n => { VizType = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("cache_timeout", CacheTimeout);
        writer.WriteStringValue("certification_details", CertificationDetails);
        writer.WriteStringValue("certified_by", CertifiedBy);
        writer.WriteCollectionOfPrimitiveValues<int?>("dashboards", Dashboards);
        writer.WriteIntValue("datasource_id", DatasourceId);
        writer.WriteStringValue("datasource_name", DatasourceName);
        writer.WriteEnumValue<Models.ChartRestApi.Post_datasource_type>("datasource_type", DatasourceType);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("external_url", ExternalUrl);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteStringValue("params", Params);
        writer.WriteStringValue("query_context", QueryContext);
        writer.WriteBoolValue("query_context_generation", QueryContextGeneration);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteStringValue("viz_type", VizType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
