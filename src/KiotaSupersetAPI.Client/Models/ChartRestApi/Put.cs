
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ChartRestApi;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Put : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Duration (in seconds) of the caching timeout for this chart. Note this defaults to the datasource/table timeout if undefined.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Details of the certification</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CertificationDetails { get; set; }
#nullable restore
#else
    public string CertificationDetails { get; set; }
#endif
    /// <summary>Person or group that has certified this chart</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? CertifiedBy { get; set; }
#nullable restore
#else
    public string CertifiedBy { get; set; }
#endif
    /// <summary>The dashboards property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<int?>? Dashboards { get; set; }
#nullable restore
#else
    public List<int?> Dashboards { get; set; }
#endif
    /// <summary>The id of the dataset/datasource this new chart will use. A complete datasource identification needs `datasource_id` and `datasource_type`.</summary>
    public int? DatasourceId { get; set; }
    /// <summary>The type of dataset/datasource identified on `datasource_id`.</summary>
    public KClient.Models.ChartRestApi.Put_datasource_type? DatasourceType { get; set; }
    /// <summary>A description of the chart propose.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The external_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? ExternalUrl { get; set; }
#nullable restore
#else
    public string ExternalUrl { get; set; }
#endif
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<int?>? Owners { get; set; }
#nullable restore
#else
    public List<int?> Owners { get; set; }
#endif
    /// <summary>Parameters are generated dynamically when clicking the save or overwrite button in the explore view. This JSON object for power users who may want to alter specific parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Params { get; set; }
#nullable restore
#else
    public string Params { get; set; }
#endif
    /// <summary>The query context represents the queries that need to run in order to generate the data the visualization, and in what format the data should be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? QueryContext { get; set; }
#nullable restore
#else
    public string QueryContext { get; set; }
#endif
    /// <summary>The query context generation represents whether the query_contextis user generated or not so that it does not update user modifiedstate.</summary>
    public bool? QueryContextGeneration { get; set; }
    /// <summary>The name of the chart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SliceName { get; set; }
#nullable restore
#else
    public string SliceName { get; set; }
#endif
    /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<KClient.Models.Tag>? Tags { get; set; }
#nullable restore
#else
    public List<KClient.Models.Tag> Tags { get; set; }
#endif
    /// <summary>The type of chart visualization used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? VizType { get; set; }
#nullable restore
#else
    public string VizType { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartRestApi.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartRestApi.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartRestApi.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartRestApi.Put();
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
            { "datasource_type", n => { DatasourceType = n.GetEnumValue<KClient.Models.ChartRestApi.Put_datasource_type>(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "external_url", n => { ExternalUrl = n.GetStringValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "params", n => { Params = n.GetStringValue(); } },
            { "query_context", n => { QueryContext = n.GetStringValue(); } },
            { "query_context_generation", n => { QueryContextGeneration = n.GetBoolValue(); } },
            { "slice_name", n => { SliceName = n.GetStringValue(); } },
            { "tags", n => { Tags = n.GetCollectionOfObjectValues<KClient.Models.Tag>(KClient.Models.Tag.CreateFromDiscriminatorValue)?.ToList(); } },
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
        writer.WriteEnumValue<KClient.Models.ChartRestApi.Put_datasource_type>("datasource_type", DatasourceType);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("external_url", ExternalUrl);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteStringValue("params", Params);
        writer.WriteStringValue("query_context", QueryContext);
        writer.WriteBoolValue("query_context_generation", QueryContextGeneration);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteCollectionOfObjectValues<KClient.Models.Tag>("tags", Tags);
        writer.WriteStringValue("viz_type", VizType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
