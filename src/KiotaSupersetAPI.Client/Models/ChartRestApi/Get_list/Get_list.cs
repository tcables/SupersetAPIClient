
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ChartRestApi.Get_list
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Get_list : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cache_timeout property</summary>
        public int? CacheTimeout { get; set; }
        /// <summary>The certification_details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationDetails { get; set; }
#nullable restore
#else
        public string CertificationDetails { get; set; }
#endif
        /// <summary>The certified_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertifiedBy { get; set; }
#nullable restore
#else
        public string CertifiedBy { get; set; }
#endif
        /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.User1? ChangedBy { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.User1 ChangedBy { get; set; }
#endif
        /// <summary>The changed_by_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ChangedByName { get; private set; }
#nullable restore
#else
        public UntypedNode ChangedByName { get; private set; }
#endif
        /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
        public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
        /// <summary>The changed_on_dttm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ChangedOnDttm { get; private set; }
#nullable restore
#else
        public UntypedNode ChangedOnDttm { get; private set; }
#endif
        /// <summary>The changed_on_utc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ChangedOnUtc { get; private set; }
#nullable restore
#else
        public UntypedNode ChangedOnUtc { get; private set; }
#endif
        /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.User2? CreatedBy { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.User2 CreatedBy { get; set; }
#endif
        /// <summary>The created_by_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? CreatedByName { get; private set; }
#nullable restore
#else
        public UntypedNode CreatedByName { get; private set; }
#endif
        /// <summary>The created_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? CreatedOnDeltaHumanized { get; private set; }
#nullable restore
#else
        public UntypedNode CreatedOnDeltaHumanized { get; private set; }
#endif
        /// <summary>The dashboards property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.Dashboard? Dashboards { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.Dashboard Dashboards { get; set; }
#endif
        /// <summary>The datasource_id property</summary>
        public int? DatasourceId { get; set; }
        /// <summary>The datasource_name_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DatasourceNameText { get; private set; }
#nullable restore
#else
        public UntypedNode DatasourceNameText { get; private set; }
#endif
        /// <summary>The datasource_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DatasourceType { get; set; }
#nullable restore
#else
        public string DatasourceType { get; set; }
#endif
        /// <summary>The datasource_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DatasourceUrl { get; private set; }
#nullable restore
#else
        public UntypedNode DatasourceUrl { get; private set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The description_markeddown property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DescriptionMarkeddown { get; private set; }
#nullable restore
#else
        public UntypedNode DescriptionMarkeddown { get; private set; }
#endif
        /// <summary>The edit_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? EditUrl { get; private set; }
#nullable restore
#else
        public UntypedNode EditUrl { get; private set; }
#endif
        /// <summary>The form_data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FormData { get; private set; }
#nullable restore
#else
        public UntypedNode FormData { get; private set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The is_managed_externally property</summary>
        public bool? IsManagedExternally { get; set; }
        /// <summary>The last_saved_at property</summary>
        public DateTimeOffset? LastSavedAt { get; set; }
        /// <summary>The last_saved_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.User? LastSavedBy { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.User LastSavedBy { get; set; }
#endif
        /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.User3? Owners { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.User3 Owners { get; set; }
#endif
        /// <summary>The params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Params { get; set; }
#nullable restore
#else
        public string Params { get; set; }
#endif
        /// <summary>The slice_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SliceName { get; set; }
#nullable restore
#else
        public string SliceName { get; set; }
#endif
        /// <summary>The slice_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? SliceUrl { get; private set; }
#nullable restore
#else
        public UntypedNode SliceUrl { get; private set; }
#endif
        /// <summary>The table property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.SqlaTable? Table { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.SqlaTable Table { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.ChartRestApi.Get_list.Tag? Tags { get; set; }
#nullable restore
#else
        public KClient.Models.ChartRestApi.Get_list.Tag Tags { get; set; }
#endif
        /// <summary>The thumbnail_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ThumbnailUrl { get; private set; }
#nullable restore
#else
        public UntypedNode ThumbnailUrl { get; private set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Url { get; private set; }
#nullable restore
#else
        public UntypedNode Url { get; private set; }
#endif
        /// <summary>The viz_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VizType { get; set; }
#nullable restore
#else
        public string VizType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.ChartRestApi.Get_list.Get_list"/> and sets the default values.
        /// </summary>
        public Get_list()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.ChartRestApi.Get_list.Get_list"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.ChartRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.ChartRestApi.Get_list.Get_list();
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
                { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.User1>(KClient.Models.ChartRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
                { "changed_by_name", n => { ChangedByName = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "changed_on_dttm", n => { ChangedOnDttm = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "changed_on_utc", n => { ChangedOnUtc = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.User2>(KClient.Models.ChartRestApi.Get_list.User2.CreateFromDiscriminatorValue); } },
                { "created_by_name", n => { CreatedByName = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "created_on_delta_humanized", n => { CreatedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "dashboards", n => { Dashboards = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.Dashboard>(KClient.Models.ChartRestApi.Get_list.Dashboard.CreateFromDiscriminatorValue); } },
                { "datasource_id", n => { DatasourceId = n.GetIntValue(); } },
                { "datasource_name_text", n => { DatasourceNameText = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "datasource_type", n => { DatasourceType = n.GetStringValue(); } },
                { "datasource_url", n => { DatasourceUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "description_markeddown", n => { DescriptionMarkeddown = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "edit_url", n => { EditUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "form_data", n => { FormData = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
                { "last_saved_at", n => { LastSavedAt = n.GetDateTimeOffsetValue(); } },
                { "last_saved_by", n => { LastSavedBy = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.User>(KClient.Models.ChartRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
                { "owners", n => { Owners = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.User3>(KClient.Models.ChartRestApi.Get_list.User3.CreateFromDiscriminatorValue); } },
                { "params", n => { Params = n.GetStringValue(); } },
                { "slice_name", n => { SliceName = n.GetStringValue(); } },
                { "slice_url", n => { SliceUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "table", n => { Table = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.SqlaTable>(KClient.Models.ChartRestApi.Get_list.SqlaTable.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetObjectValue<KClient.Models.ChartRestApi.Get_list.Tag>(KClient.Models.ChartRestApi.Get_list.Tag.CreateFromDiscriminatorValue); } },
                { "thumbnail_url", n => { ThumbnailUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "url", n => { Url = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.User1>("changed_by", ChangedBy);
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.User2>("created_by", CreatedBy);
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.Dashboard>("dashboards", Dashboards);
            writer.WriteIntValue("datasource_id", DatasourceId);
            writer.WriteStringValue("datasource_type", DatasourceType);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
            writer.WriteDateTimeOffsetValue("last_saved_at", LastSavedAt);
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.User>("last_saved_by", LastSavedBy);
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.User3>("owners", Owners);
            writer.WriteStringValue("params", Params);
            writer.WriteStringValue("slice_name", SliceName);
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.SqlaTable>("table", Table);
            writer.WriteObjectValue<KClient.Models.ChartRestApi.Get_list.Tag>("tags", Tags);
            writer.WriteStringValue("viz_type", VizType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
