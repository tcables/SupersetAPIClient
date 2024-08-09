
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.DatasetRestAPI;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Put : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The always_filter_main_dttm property</summary>
    public bool? AlwaysFilterMainDttm { get; set; }
    /// <summary>The cache_timeout property</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>The columns property</summary>
    public List<Models.DatasetColumnsPut> Columns { get; set; }

    /// <summary>The database_id property</summary>
    public int? DatabaseId { get; set; }
    /// <summary>The default_endpoint property</summary>
    public string DefaultEndpoint { get; set; }

    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The external_url property</summary>
    public string ExternalUrl { get; set; }

    /// <summary>The extra property</summary>
    public string Extra { get; set; }

    /// <summary>The fetch_values_predicate property</summary>
    public string FetchValuesPredicate { get; set; }

    /// <summary>The filter_select_enabled property</summary>
    public bool? FilterSelectEnabled { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The is_sqllab_view property</summary>
    public bool? IsSqllabView { get; set; }
    /// <summary>The main_dttm_col property</summary>
    public string MainDttmCol { get; set; }

    /// <summary>The metrics property</summary>
    public List<Models.DatasetMetricsPut> Metrics { get; set; }

    /// <summary>The normalize_columns property</summary>
    public bool? NormalizeColumns { get; set; }
    /// <summary>The offset property</summary>
    public int? Offset { get; set; }
    /// <summary>The owners property</summary>
    public List<int?> Owners { get; set; }

    /// <summary>The schema property</summary>
    public string Schema { get; set; }

    /// <summary>The sql property</summary>
    public string Sql { get; set; }

    /// <summary>The table_name property</summary>
    public string TableName { get; set; }

    /// <summary>The template_params property</summary>
    public string TemplateParams { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatasetRestAPI.Put"/> and sets the default values.
    /// </summary>
    public Put()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatasetRestAPI.Put"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatasetRestAPI.Put CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatasetRestAPI.Put();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "always_filter_main_dttm", n => { AlwaysFilterMainDttm = n.GetBoolValue(); } },
            { "cache_timeout", n => { CacheTimeout = n.GetIntValue(); } },
            { "columns", n => { Columns = n.GetCollectionOfObjectValues<Models.DatasetColumnsPut>(Models.DatasetColumnsPut.CreateFromDiscriminatorValue)?.ToList(); } },
            { "database_id", n => { DatabaseId = n.GetIntValue(); } },
            { "default_endpoint", n => { DefaultEndpoint = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "external_url", n => { ExternalUrl = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "fetch_values_predicate", n => { FetchValuesPredicate = n.GetStringValue(); } },
            { "filter_select_enabled", n => { FilterSelectEnabled = n.GetBoolValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "is_sqllab_view", n => { IsSqllabView = n.GetBoolValue(); } },
            { "main_dttm_col", n => { MainDttmCol = n.GetStringValue(); } },
            { "metrics", n => { Metrics = n.GetCollectionOfObjectValues<Models.DatasetMetricsPut>(Models.DatasetMetricsPut.CreateFromDiscriminatorValue)?.ToList(); } },
            { "normalize_columns", n => { NormalizeColumns = n.GetBoolValue(); } },
            { "offset", n => { Offset = n.GetIntValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "table_name", n => { TableName = n.GetStringValue(); } },
            { "template_params", n => { TemplateParams = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("always_filter_main_dttm", AlwaysFilterMainDttm);
        writer.WriteIntValue("cache_timeout", CacheTimeout);
        writer.WriteCollectionOfObjectValues<Models.DatasetColumnsPut>("columns", Columns);
        writer.WriteIntValue("database_id", DatabaseId);
        writer.WriteStringValue("default_endpoint", DefaultEndpoint);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("external_url", ExternalUrl);
        writer.WriteStringValue("extra", Extra);
        writer.WriteStringValue("fetch_values_predicate", FetchValuesPredicate);
        writer.WriteBoolValue("filter_select_enabled", FilterSelectEnabled);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteBoolValue("is_sqllab_view", IsSqllabView);
        writer.WriteStringValue("main_dttm_col", MainDttmCol);
        writer.WriteCollectionOfObjectValues<Models.DatasetMetricsPut>("metrics", Metrics);
        writer.WriteBoolValue("normalize_columns", NormalizeColumns);
        writer.WriteIntValue("offset", Offset);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteStringValue("template_params", TemplateParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
