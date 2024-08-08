
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_column_formats? ColumnFormats { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_column_formats ColumnFormats { get; set; }
#endif
        /// <summary>Columns metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.Dataset_columns>? Columns { get; set; }
#nullable restore
#else
        public List<KClient.Models.Dataset_columns> Columns { get; set; }
#endif
        /// <summary>Currency formats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_currency_formats? CurrencyFormats { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_currency_formats CurrencyFormats { get; set; }
#endif
        /// <summary>Database associated with the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_database? Database { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_database Database { get; set; }
#endif
        /// <summary>Dataset name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatasourceName { get; set; }
#nullable restore
#else
        public string DatasourceName { get; set; }
#endif
        /// <summary>Default endpoint for the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultEndpoint { get; set; }
#nullable restore
#else
        public string DefaultEndpoint { get; set; }
#endif
        /// <summary>Dataset description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The URL for editing the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EditUrl { get; set; }
#nullable restore
#else
        public string EditUrl { get; set; }
#endif
        /// <summary>JSON string containing extra configuration elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_extra? Extra { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_extra Extra { get; set; }
#endif
        /// <summary>Predicate used when fetching values from the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FetchValuesPredicate { get; set; }
#nullable restore
#else
        public string FetchValuesPredicate { get; set; }
#endif
        /// <summary>SELECT filter applied to the dataset.</summary>
        public bool? FilterSelect { get; set; }
        /// <summary>If the SELECT filter is enabled.</summary>
        public bool? FilterSelectEnabled { get; set; }
        /// <summary>Name of temporal column used for time filtering for SQL datasources. This field is deprecated, use `granularity` instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? GranularitySqla { get; set; }
#nullable restore
#else
        public UntypedNode GranularitySqla { get; set; }
#endif
        /// <summary>Health check message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HealthCheckMessage { get; set; }
#nullable restore
#else
        public string HealthCheckMessage { get; set; }
#endif
        /// <summary>Dataset ID.</summary>
        public int? Id { get; set; }
        /// <summary>If the dataset is a SQL Lab view.</summary>
        public bool? IsSqllabView { get; set; }
        /// <summary>The main temporal column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MainDttmCol { get; set; }
#nullable restore
#else
        public string MainDttmCol { get; set; }
#endif
        /// <summary>Dataset metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.Dataset_metrics>? Metrics { get; set; }
#nullable restore
#else
        public List<KClient.Models.Dataset_metrics> Metrics { get; set; }
#endif
        /// <summary>Dataset name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Dataset offset.</summary>
        public int? Offset { get; set; }
        /// <summary>List of order by columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? OrderByChoices { get; set; }
#nullable restore
#else
        public UntypedNode OrderByChoices { get; set; }
#endif
        /// <summary>List of owners identifiers</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Owners { get; set; }
#nullable restore
#else
        public List<int?> Owners { get; set; }
#endif
        /// <summary>Extra params for the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_params? Params { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_params Params { get; set; }
#endif
        /// <summary>Permission expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Perm { get; set; }
#nullable restore
#else
        public string Perm { get; set; }
#endif
        /// <summary>Dataset schema.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Schema { get; set; }
#nullable restore
#else
        public string Schema { get; set; }
#endif
        /// <summary>Select all clause.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectStar { get; set; }
#nullable restore
#else
        public string SelectStar { get; set; }
#endif
        /// <summary>A SQL statement that defines the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sql { get; set; }
#nullable restore
#else
        public string Sql { get; set; }
#endif
        /// <summary>The name of the table associated with the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TableName { get; set; }
#nullable restore
#else
        public string TableName { get; set; }
#endif
        /// <summary>Table template params.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_template_params? TemplateParams { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_template_params TemplateParams { get; set; }
#endif
        /// <summary>List of temporal granularities supported by the dataset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? TimeGrainSqla { get; set; }
#nullable restore
#else
        public UntypedNode TimeGrainSqla { get; set; }
#endif
        /// <summary>Dataset type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>Dataset unique identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uid { get; set; }
#nullable restore
#else
        public string Uid { get; set; }
#endif
        /// <summary>Mapping from raw name to verbose name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Dataset_verbose_map? VerboseMap { get; set; }
#nullable restore
#else
        public KClient.Models.Dataset_verbose_map VerboseMap { get; set; }
#endif
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
}
