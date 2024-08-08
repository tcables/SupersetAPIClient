
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DatasetRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The always_filter_main_dttm property</summary>
    public bool? AlwaysFilterMainDttm { get; set; }
    /// <summary>The cache_timeout property</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get.User? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get.User ChangedBy { get; set; }
#endif
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnHumanized { get; private set; }
#endif
    /// <summary>The column_formats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ColumnFormats { get; private set; }
#nullable restore
#else
    public UntypedNode ColumnFormats { get; private set; }
#endif
    /// <summary>The columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get.TableColumn? Columns { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get.TableColumn Columns { get; set; }
#endif
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get.User1? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get.User1 CreatedBy { get; set; }
#endif
    /// <summary>The created_on property</summary>
    public DateTimeOffset? CreatedOn { get; set; }
    /// <summary>The created_on_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? CreatedOnHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode CreatedOnHumanized { get; private set; }
#endif
    /// <summary>The currency_formats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? CurrencyFormats { get; private set; }
#nullable restore
#else
    public UntypedNode CurrencyFormats { get; private set; }
#endif
    /// <summary>The database property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get.Database? Database { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get.Database Database { get; set; }
#endif
    /// <summary>The datasource_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? DatasourceName { get; private set; }
#nullable restore
#else
    public UntypedNode DatasourceName { get; private set; }
#endif
    /// <summary>The datasource_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? DatasourceType { get; private set; }
#nullable restore
#else
    public UntypedNode DatasourceType { get; private set; }
#endif
    /// <summary>The default_endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DefaultEndpoint { get; set; }
#nullable restore
#else
    public string DefaultEndpoint { get; set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The extra property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Extra { get; set; }
#nullable restore
#else
    public string Extra { get; set; }
#endif
    /// <summary>The fetch_values_predicate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? FetchValuesPredicate { get; set; }
#nullable restore
#else
    public string FetchValuesPredicate { get; set; }
#endif
    /// <summary>The filter_select_enabled property</summary>
    public bool? FilterSelectEnabled { get; set; }
    /// <summary>The granularity_sqla property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? GranularitySqla { get; private set; }
#nullable restore
#else
    public UntypedNode GranularitySqla { get; private set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The is_sqllab_view property</summary>
    public bool? IsSqllabView { get; set; }
    /// <summary>The kind property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Kind { get; private set; }
#nullable restore
#else
    public UntypedNode Kind { get; private set; }
#endif
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
    public KClient.Models.DatasetRestApi.Get.SqlMetric? Metrics { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get.SqlMetric Metrics { get; set; }
#endif
    /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Name { get; private set; }
#nullable restore
#else
    public UntypedNode Name { get; private set; }
#endif
    /// <summary>The normalize_columns property</summary>
    public bool? NormalizeColumns { get; set; }
    /// <summary>The offset property</summary>
    public int? Offset { get; set; }
    /// <summary>The order_by_choices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? OrderByChoices { get; private set; }
#nullable restore
#else
    public UntypedNode OrderByChoices { get; private set; }
#endif
    /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DatasetRestApi.Get.User2? Owners { get; set; }
#nullable restore
#else
    public KClient.Models.DatasetRestApi.Get.User2 Owners { get; set; }
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
    public UntypedNode? SelectStar { get; private set; }
#nullable restore
#else
    public UntypedNode SelectStar { get; private set; }
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
    public UntypedNode? TimeGrainSqla { get; private set; }
#nullable restore
#else
    public UntypedNode TimeGrainSqla { get; private set; }
#endif
    /// <summary>The uid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Uid { get; private set; }
#nullable restore
#else
    public UntypedNode Uid { get; private set; }
#endif
    /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Url { get; private set; }
#nullable restore
#else
    public UntypedNode Url { get; private set; }
#endif
    /// <summary>The verbose_map property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? VerboseMap { get; private set; }
#nullable restore
#else
    public UntypedNode VerboseMap { get; private set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatasetRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatasetRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatasetRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatasetRestApi.Get.Get();
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
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.DatasetRestApi.Get.User>(KClient.Models.DatasetRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_humanized", n => { ChangedOnHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "column_formats", n => { ColumnFormats = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "columns", n => { Columns = n.GetObjectValue<KClient.Models.DatasetRestApi.Get.TableColumn>(KClient.Models.DatasetRestApi.Get.TableColumn.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.DatasetRestApi.Get.User1>(KClient.Models.DatasetRestApi.Get.User1.CreateFromDiscriminatorValue); } },
            { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
            { "created_on_humanized", n => { CreatedOnHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "currency_formats", n => { CurrencyFormats = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "database", n => { Database = n.GetObjectValue<KClient.Models.DatasetRestApi.Get.Database>(KClient.Models.DatasetRestApi.Get.Database.CreateFromDiscriminatorValue); } },
            { "datasource_name", n => { DatasourceName = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "datasource_type", n => { DatasourceType = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "default_endpoint", n => { DefaultEndpoint = n.GetStringValue(); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "fetch_values_predicate", n => { FetchValuesPredicate = n.GetStringValue(); } },
            { "filter_select_enabled", n => { FilterSelectEnabled = n.GetBoolValue(); } },
            { "granularity_sqla", n => { GranularitySqla = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "is_sqllab_view", n => { IsSqllabView = n.GetBoolValue(); } },
            { "kind", n => { Kind = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "main_dttm_col", n => { MainDttmCol = n.GetStringValue(); } },
            { "metrics", n => { Metrics = n.GetObjectValue<KClient.Models.DatasetRestApi.Get.SqlMetric>(KClient.Models.DatasetRestApi.Get.SqlMetric.CreateFromDiscriminatorValue); } },
            { "name", n => { Name = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "normalize_columns", n => { NormalizeColumns = n.GetBoolValue(); } },
            { "offset", n => { Offset = n.GetIntValue(); } },
            { "order_by_choices", n => { OrderByChoices = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "owners", n => { Owners = n.GetObjectValue<KClient.Models.DatasetRestApi.Get.User2>(KClient.Models.DatasetRestApi.Get.User2.CreateFromDiscriminatorValue); } },
            { "schema", n => { Schema = n.GetStringValue(); } },
            { "select_star", n => { SelectStar = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "sql", n => { Sql = n.GetStringValue(); } },
            { "table_name", n => { TableName = n.GetStringValue(); } },
            { "template_params", n => { TemplateParams = n.GetStringValue(); } },
            { "time_grain_sqla", n => { TimeGrainSqla = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "uid", n => { Uid = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "url", n => { Url = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "verbose_map", n => { VerboseMap = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get.User>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get.TableColumn>("columns", Columns);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get.User1>("created_by", CreatedBy);
        writer.WriteDateTimeOffsetValue("created_on", CreatedOn);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get.Database>("database", Database);
        writer.WriteStringValue("default_endpoint", DefaultEndpoint);
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("extra", Extra);
        writer.WriteStringValue("fetch_values_predicate", FetchValuesPredicate);
        writer.WriteBoolValue("filter_select_enabled", FilterSelectEnabled);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteBoolValue("is_sqllab_view", IsSqllabView);
        writer.WriteStringValue("main_dttm_col", MainDttmCol);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get.SqlMetric>("metrics", Metrics);
        writer.WriteBoolValue("normalize_columns", NormalizeColumns);
        writer.WriteIntValue("offset", Offset);
        writer.WriteObjectValue<KClient.Models.DatasetRestApi.Get.User2>("owners", Owners);
        writer.WriteStringValue("schema", Schema);
        writer.WriteStringValue("sql", Sql);
        writer.WriteStringValue("table_name", TableName);
        writer.WriteStringValue("template_params", TemplateParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
