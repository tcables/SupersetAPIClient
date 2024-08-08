
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Dataset : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Duration (in seconds) of the caching timeout for this dataset.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Column formats.</summary>
    public KClient.Models.Dataset_column_formats ColumnFormats { get; set; }

    /// <summary>Columns metadata.</summary>
    public List<KClient.Models.Dataset_columns> Columns { get; set; }

    /// <summary>Currency formats.</summary>
    public KClient.Models.Dataset_currency_formats CurrencyFormats { get; set; }

    /// <summary>Database associated with the dataset.</summary>
    public KClient.Models.Dataset_database Database { get; set; }

    /// <summary>Dataset name.</summary>
    public string DatasourceName { get; set; }

    /// <summary>Default endpoint for the dataset.</summary>
    public string DefaultEndpoint { get; set; }

    /// <summary>Dataset description.</summary>
    public string Description { get; set; }

    /// <summary>The URL for editing the dataset.</summary>
    public string EditUrl { get; set; }

    /// <summary>JSON string containing extra configuration elements.</summary>
    public KClient.Models.Dataset_extra Extra { get; set; }

    /// <summary>Predicate used when fetching values from the dataset.</summary>
    public string FetchValuesPredicate { get; set; }

    /// <summary>SELECT filter applied to the dataset.</summary>
    public bool? FilterSelect { get; set; }
    /// <summary>If the SELECT filter is enabled.</summary>
    public bool? FilterSelectEnabled { get; set; }
    /// <summary>Name of temporal column used for time filtering for SQL datasources. This field is deprecated, use `granularity` instead.</summary>
    public UntypedNode GranularitySqla { get; set; }

    /// <summary>Health check message.</summary>
    public string HealthCheckMessage { get; set; }

    /// <summary>Dataset ID.</summary>
    public int? Id { get; set; }
    /// <summary>If the dataset is a SQL Lab view.</summary>
    public bool? IsSqllabView { get; set; }
    /// <summary>The main temporal column.</summary>
    public string MainDttmCol { get; set; }

    /// <summary>Dataset metrics.</summary>
    public List<KClient.Models.Dataset_metrics> Metrics { get; set; }

    /// <summary>Dataset name.</summary>
    public string Name { get; set; }

    /// <summary>Dataset offset.</summary>
    public int? Offset { get; set; }
    /// <summary>List of order by columns.</summary>
    public UntypedNode OrderByChoices { get; set; }

    /// <summary>List of owners identifiers</summary>
    public List<int?> Owners { get; set; }

    /// <summary>Extra params for the dataset.</summary>
    public KClient.Models.Dataset_params Params { get; set; }

    /// <summary>Permission expression.</summary>
    public string Perm { get; set; }

    /// <summary>Dataset schema.</summary>
    public string Schema { get; set; }

    /// <summary>Select all clause.</summary>
    public string SelectStar { get; set; }

    /// <summary>A SQL statement that defines the dataset.</summary>
    public string Sql { get; set; }

    /// <summary>The name of the table associated with the dataset.</summary>
    public string TableName { get; set; }

    /// <summary>Table template params.</summary>
    public KClient.Models.Dataset_template_params TemplateParams { get; set; }

    /// <summary>List of temporal granularities supported by the dataset.</summary>
    public UntypedNode TimeGrainSqla { get; set; }

    /// <summary>Dataset type.</summary>
    public string Type { get; set; }

    /// <summary>Dataset unique identifier.</summary>
    public string Uid { get; set; }

    /// <summary>Mapping from raw name to verbose name.</summary>
    public KClient.Models.Dataset_verbose_map VerboseMap { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.Dataset"/> and sets the default values.
    /// </summary>
    public Dataset()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.Dataset"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.Dataset CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.Dataset();
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
            { "column_formats", n => { ColumnFormats = n.GetObjectValue<KClient.Models.Dataset_column_formats>(KClient.Models.Dataset_column_formats.CreateFromDiscriminatorValue); } },
            { "columns", n => { Columns = n.GetCollectionOfObjectValues<KClient.Models.Dataset_columns>(KClient.Models.Dataset_columns.CreateFromDiscriminatorValue)?.ToList(); } },
            { "currency_formats", n => { CurrencyFormats = n.GetObjectValue<KClient.Models.Dataset_currency_formats>(KClient.Models.Dataset_currency_formats.CreateFromDiscriminatorValue); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.Dataset_database>(KClient.Models.Dataset_database.CreateFromDiscriminatorValue); } },
            { "datasource_name", n => { DatasourceName = n.GetStringValue(); } },
            { "default_endpoint", n => { DefaultEndpoint = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "edit_url", n => { EditUrl = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetObjectValue<KClient.Models.Dataset_extra>(KClient.Models.Dataset_extra.CreateFromDiscriminatorValue); } },
            { "fetch_values_predicate", n => { FetchValuesPredicate = n.GetStringValue(); } },
            { "filter_select", n => { FilterSelect = n.GetBoolValue(); } },
            { "filter_select_enabled", n => { FilterSelectEnabled = n.GetBoolValue(); } },
            { "granularity_sqla", n => { GranularitySqla = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "health_check_message", n => { HealthCheckMessage = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_sqllab_view", n => { IsSqllabView = n.GetBoolValue(); } },
            { "main_dttm_col", n => { MainDttmCol = n.GetStringValue(); } },
            { "metrics", n => { Metrics = n.GetCollectionOfObjectValues<KClient.Models.Dataset_metrics>(KClient.Models.Dataset_metrics.CreateFromDiscriminatorValue)?.ToList(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "offset", n => { Offset = n.GetIntValue(); } },
            { "order_by_choices", n => { OrderByChoices = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            { "params", n => { Params = n.GetObjectValue<KClient.Models.Dataset_params>(KClient.Models.Dataset_params.CreateFromDiscriminatorValue); } },
            { "perm", n => { Perm = n.GetStringValue(); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "select_star", n => { SelectStar = n.GetStringValue(); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "table_name", n => { TableName = n.GetStringValue(); } },
            { "template_params", n => { TemplateParams = n.GetObjectValue<KClient.Models.Dataset_template_params>(KClient.Models.Dataset_template_params.CreateFromDiscriminatorValue); } },
            { "time_grain_sqla", n => { TimeGrainSqla = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "type", n => { Type = n.GetStringValue(); } },
            { "uid", n => { Uid = n.GetStringValue(); } },
            { "verbose_map", n => { VerboseMap = n.GetObjectValue<KClient.Models.Dataset_verbose_map>(KClient.Models.Dataset_verbose_map.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.Dataset_column_formats>("column_formats", ColumnFormats);
        writer.WriteCollectionOfObjectValues<KClient.Models.Dataset_columns>("columns", Columns);
        writer.WriteObjectValue<KClient.Models.Dataset_currency_formats>("currency_formats", CurrencyFormats);
        writer.WriteObjectValue<KClient.Models.Dataset_database>("database", Database);
        writer.WriteStringValue("datasource_name", DatasourceName);
        writer.WriteStringValue("default_endpoint", DefaultEndpoint);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("edit_url", EditUrl);
        writer.WriteObjectValue<KClient.Models.Dataset_extra>("extra", Extra);
        writer.WriteStringValue("fetch_values_predicate", FetchValuesPredicate);
        writer.WriteBoolValue("filter_select", FilterSelect);
        writer.WriteBoolValue("filter_select_enabled", FilterSelectEnabled);
        writer.WriteObjectValue<UntypedNode>("granularity_sqla", GranularitySqla);
        writer.WriteStringValue("health_check_message", HealthCheckMessage);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_sqllab_view", IsSqllabView);
        writer.WriteStringValue("main_dttm_col", MainDttmCol);
        writer.WriteCollectionOfObjectValues<KClient.Models.Dataset_metrics>("metrics", Metrics);
        writer.WriteStringValue("name", Name);
        writer.WriteIntValue("offset", Offset);
        writer.WriteObjectValue<UntypedNode>("order_by_choices", OrderByChoices);
        writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
        writer.WriteObjectValue<KClient.Models.Dataset_params>("params", Params);
        writer.WriteStringValue("perm", Perm);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("select_star", SelectStar);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteObjectValue<KClient.Models.Dataset_template_params>("template_params", TemplateParams);
        writer.WriteObjectValue<UntypedNode>("time_grain_sqla", TimeGrainSqla);
        writer.WriteStringValue("type", Type);
        writer.WriteStringValue("uid", Uid);
        writer.WriteObjectValue<KClient.Models.Dataset_verbose_map>("verbose_map", VerboseMap);
        writer.WriteAdditionalData(AdditionalData);
    }
}
