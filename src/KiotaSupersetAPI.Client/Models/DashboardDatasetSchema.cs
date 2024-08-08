
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
    public partial class DashboardDatasetSchema : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The always_filter_main_dttm property</summary>
        public bool? AlwaysFilterMainDttm { get; set; }
        /// <summary>The cache_timeout property</summary>
        public int? CacheTimeout { get; set; }
        /// <summary>The column_formats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.DashboardDatasetSchema_column_formats? ColumnFormats { get; set; }
#nullable restore
#else
        public KClient.Models.DashboardDatasetSchema_column_formats ColumnFormats { get; set; }
#endif
        /// <summary>The columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.DashboardDatasetSchema_columns>? Columns { get; set; }
#nullable restore
#else
        public List<KClient.Models.DashboardDatasetSchema_columns> Columns { get; set; }
#endif
        /// <summary>The column_types property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? ColumnTypes { get; set; }
#nullable restore
#else
        public List<int?> ColumnTypes { get; set; }
#endif
        /// <summary>The currency_formats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.DashboardDatasetSchema_currency_formats? CurrencyFormats { get; set; }
#nullable restore
#else
        public KClient.Models.DashboardDatasetSchema_currency_formats CurrencyFormats { get; set; }
#endif
        /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.Database? Database { get; set; }
#nullable restore
#else
        public KClient.Models.Database Database { get; set; }
#endif
        /// <summary>The datasource_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatasourceName { get; set; }
#nullable restore
#else
        public string DatasourceName { get; set; }
#endif
        /// <summary>The default_endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultEndpoint { get; set; }
#nullable restore
#else
        public string DefaultEndpoint { get; set; }
#endif
        /// <summary>The edit_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EditUrl { get; set; }
#nullable restore
#else
        public string EditUrl { get; set; }
#endif
        /// <summary>The fetch_values_predicate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FetchValuesPredicate { get; set; }
#nullable restore
#else
        public string FetchValuesPredicate { get; set; }
#endif
        /// <summary>The filter_select property</summary>
        public bool? FilterSelect { get; set; }
        /// <summary>The filter_select_enabled property</summary>
        public bool? FilterSelectEnabled { get; set; }
        /// <summary>The granularity_sqla property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? GranularitySqla { get; set; }
#nullable restore
#else
        public UntypedNode GranularitySqla { get; set; }
#endif
        /// <summary>The health_check_message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HealthCheckMessage { get; set; }
#nullable restore
#else
        public string HealthCheckMessage { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The is_sqllab_view property</summary>
        public bool? IsSqllabView { get; set; }
        /// <summary>The main_dttm_col property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MainDttmCol { get; set; }
#nullable restore
#else
        public string MainDttmCol { get; set; }
#endif
        /// <summary>The metrics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.DashboardDatasetSchema_metrics>? Metrics { get; set; }
#nullable restore
#else
        public List<KClient.Models.DashboardDatasetSchema_metrics> Metrics { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The normalize_columns property</summary>
        public bool? NormalizeColumns { get; set; }
        /// <summary>The offset property</summary>
        public int? Offset { get; set; }
        /// <summary>The order_by_choices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? OrderByChoices { get; set; }
#nullable restore
#else
        public UntypedNode OrderByChoices { get; set; }
#endif
        /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KClient.Models.DashboardDatasetSchema_owners>? Owners { get; set; }
#nullable restore
#else
        public List<KClient.Models.DashboardDatasetSchema_owners> Owners { get; set; }
#endif
        /// <summary>The params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Params { get; set; }
#nullable restore
#else
        public string Params { get; set; }
#endif
        /// <summary>The perm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Perm { get; set; }
#nullable restore
#else
        public string Perm { get; set; }
#endif
        /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Schema { get; set; }
#nullable restore
#else
        public string Schema { get; set; }
#endif
        /// <summary>The select_star property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectStar { get; set; }
#nullable restore
#else
        public string SelectStar { get; set; }
#endif
        /// <summary>The sql property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sql { get; set; }
#nullable restore
#else
        public string Sql { get; set; }
#endif
        /// <summary>The table_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TableName { get; set; }
#nullable restore
#else
        public string TableName { get; set; }
#endif
        /// <summary>The template_params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateParams { get; set; }
#nullable restore
#else
        public string TemplateParams { get; set; }
#endif
        /// <summary>The time_grain_sqla property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? TimeGrainSqla { get; set; }
#nullable restore
#else
        public UntypedNode TimeGrainSqla { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The uid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uid { get; set; }
#nullable restore
#else
        public string Uid { get; set; }
#endif
        /// <summary>The verbose_map property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.DashboardDatasetSchema_verbose_map? VerboseMap { get; set; }
#nullable restore
#else
        public KClient.Models.DashboardDatasetSchema_verbose_map VerboseMap { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.DashboardDatasetSchema"/> and sets the default values.
        /// </summary>
        public DashboardDatasetSchema()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.DashboardDatasetSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.DashboardDatasetSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.DashboardDatasetSchema();
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
                { "column_formats", n => { ColumnFormats = n.GetObjectValue<KClient.Models.DashboardDatasetSchema_column_formats>(KClient.Models.DashboardDatasetSchema_column_formats.CreateFromDiscriminatorValue); } },
                { "column_types", n => { ColumnTypes = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<KClient.Models.DashboardDatasetSchema_columns>(KClient.Models.DashboardDatasetSchema_columns.CreateFromDiscriminatorValue)?.ToList(); } },
                { "currency_formats", n => { CurrencyFormats = n.GetObjectValue<KClient.Models.DashboardDatasetSchema_currency_formats>(KClient.Models.DashboardDatasetSchema_currency_formats.CreateFromDiscriminatorValue); } },
                { "database", n => { Database = n.GetObjectValue<KClient.Models.Database>(KClient.Models.Database.CreateFromDiscriminatorValue); } },
                { "datasource_name", n => { DatasourceName = n.GetStringValue(); } },
                { "default_endpoint", n => { DefaultEndpoint = n.GetStringValue(); } },
                { "edit_url", n => { EditUrl = n.GetStringValue(); } },
                { "fetch_values_predicate", n => { FetchValuesPredicate = n.GetStringValue(); } },
                { "filter_select", n => { FilterSelect = n.GetBoolValue(); } },
                { "filter_select_enabled", n => { FilterSelectEnabled = n.GetBoolValue(); } },
                { "granularity_sqla", n => { GranularitySqla = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "health_check_message", n => { HealthCheckMessage = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "is_sqllab_view", n => { IsSqllabView = n.GetBoolValue(); } },
                { "main_dttm_col", n => { MainDttmCol = n.GetStringValue(); } },
                { "metrics", n => { Metrics = n.GetCollectionOfObjectValues<KClient.Models.DashboardDatasetSchema_metrics>(KClient.Models.DashboardDatasetSchema_metrics.CreateFromDiscriminatorValue)?.ToList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "normalize_columns", n => { NormalizeColumns = n.GetBoolValue(); } },
                { "offset", n => { Offset = n.GetIntValue(); } },
                { "order_by_choices", n => { OrderByChoices = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "owners", n => { Owners = n.GetCollectionOfObjectValues<KClient.Models.DashboardDatasetSchema_owners>(KClient.Models.DashboardDatasetSchema_owners.CreateFromDiscriminatorValue)?.ToList(); } },
                { "params", n => { Params = n.GetStringValue(); } },
                { "perm", n => { Perm = n.GetStringValue(); } },
                { "schema", n => { Schema = n.GetStringValue(); } },
                { "select_star", n => { SelectStar = n.GetStringValue(); } },
                { "sql", n => { Sql = n.GetStringValue(); } },
                { "table_name", n => { TableName = n.GetStringValue(); } },
                { "template_params", n => { TemplateParams = n.GetStringValue(); } },
                { "time_grain_sqla", n => { TimeGrainSqla = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "uid", n => { Uid = n.GetStringValue(); } },
                { "verbose_map", n => { VerboseMap = n.GetObjectValue<KClient.Models.DashboardDatasetSchema_verbose_map>(KClient.Models.DashboardDatasetSchema_verbose_map.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<KClient.Models.DashboardDatasetSchema_column_formats>("column_formats", ColumnFormats);
            writer.WriteCollectionOfObjectValues<KClient.Models.DashboardDatasetSchema_columns>("columns", Columns);
            writer.WriteCollectionOfPrimitiveValues<int?>("column_types", ColumnTypes);
            writer.WriteObjectValue<KClient.Models.DashboardDatasetSchema_currency_formats>("currency_formats", CurrencyFormats);
            writer.WriteObjectValue<KClient.Models.Database>("database", Database);
            writer.WriteStringValue("datasource_name", DatasourceName);
            writer.WriteStringValue("default_endpoint", DefaultEndpoint);
            writer.WriteStringValue("edit_url", EditUrl);
            writer.WriteStringValue("fetch_values_predicate", FetchValuesPredicate);
            writer.WriteBoolValue("filter_select", FilterSelect);
            writer.WriteBoolValue("filter_select_enabled", FilterSelectEnabled);
            writer.WriteObjectValue<UntypedNode>("granularity_sqla", GranularitySqla);
            writer.WriteStringValue("health_check_message", HealthCheckMessage);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("is_sqllab_view", IsSqllabView);
            writer.WriteStringValue("main_dttm_col", MainDttmCol);
            writer.WriteCollectionOfObjectValues<KClient.Models.DashboardDatasetSchema_metrics>("metrics", Metrics);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("normalize_columns", NormalizeColumns);
            writer.WriteIntValue("offset", Offset);
            writer.WriteObjectValue<UntypedNode>("order_by_choices", OrderByChoices);
            writer.WriteCollectionOfObjectValues<KClient.Models.DashboardDatasetSchema_owners>("owners", Owners);
            writer.WriteStringValue("params", Params);
            writer.WriteStringValue("perm", Perm);
            writer.WriteStringValue("schema", Schema);
            writer.WriteStringValue("select_star", SelectStar);
            writer.WriteStringValue("sql", Sql);
            writer.WriteStringValue("table_name", TableName);
            writer.WriteStringValue("template_params", TemplateParams);
            writer.WriteObjectValue<UntypedNode>("time_grain_sqla", TimeGrainSqla);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("uid", Uid);
            writer.WriteObjectValue<KClient.Models.DashboardDatasetSchema_verbose_map>("verbose_map", VerboseMap);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
