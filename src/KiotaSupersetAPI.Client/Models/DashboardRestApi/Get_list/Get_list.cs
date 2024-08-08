
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DashboardRestApi.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get_list : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
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
    public KClient.Models.DashboardRestApi.Get_list.User? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DashboardRestApi.Get_list.User ChangedBy { get; set; }
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
    public KClient.Models.DashboardRestApi.Get_list.User1? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.DashboardRestApi.Get_list.User1 CreatedBy { get; set; }
#endif
    /// <summary>The created_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? CreatedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode CreatedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The css property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Css { get; set; }
#nullable restore
#else
    public string Css { get; set; }
#endif
    /// <summary>The dashboard_title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DashboardTitle { get; set; }
#nullable restore
#else
    public string DashboardTitle { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The json_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? JsonMetadata { get; set; }
#nullable restore
#else
    public string JsonMetadata { get; set; }
#endif
    /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DashboardRestApi.Get_list.User2? Owners { get; set; }
#nullable restore
#else
    public KClient.Models.DashboardRestApi.Get_list.User2 Owners { get; set; }
#endif
    /// <summary>The position_json property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? PositionJson { get; set; }
#nullable restore
#else
    public string PositionJson { get; set; }
#endif
    /// <summary>The published property</summary>
    public bool? Published { get; set; }
    /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DashboardRestApi.Get_list.Role? Roles { get; set; }
#nullable restore
#else
    public KClient.Models.DashboardRestApi.Get_list.Role Roles { get; set; }
#endif
    /// <summary>The slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Slug { get; set; }
#nullable restore
#else
    public string Slug { get; set; }
#endif
    /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Status { get; private set; }
#nullable restore
#else
    public UntypedNode Status { get; private set; }
#endif
    /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.DashboardRestApi.Get_list.Tag? Tags { get; set; }
#nullable restore
#else
    public KClient.Models.DashboardRestApi.Get_list.Tag Tags { get; set; }
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
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DashboardRestApi.Get_list.Get_list"/> and sets the default values.
    /// </summary>
    public Get_list()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DashboardRestApi.Get_list.Get_list"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DashboardRestApi.Get_list.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DashboardRestApi.Get_list.Get_list();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "certification_details", n => { CertificationDetails = n.GetStringValue(); } },
            { "certified_by", n => { CertifiedBy = n.GetStringValue(); } },
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.DashboardRestApi.Get_list.User>(KClient.Models.DashboardRestApi.Get_list.User.CreateFromDiscriminatorValue); } },
            { "changed_by_name", n => { ChangedByName = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "changed_on_utc", n => { ChangedOnUtc = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.DashboardRestApi.Get_list.User1>(KClient.Models.DashboardRestApi.Get_list.User1.CreateFromDiscriminatorValue); } },
            { "created_on_delta_humanized", n => { CreatedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "css", n => { Css = n.GetStringValue(); } },
            { "dashboard_title", n => { DashboardTitle = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetObjectValue<KClient.Models.DashboardRestApi.Get_list.User2>(KClient.Models.DashboardRestApi.Get_list.User2.CreateFromDiscriminatorValue); } },
            { "position_json", n => { PositionJson = n.GetStringValue(); } },
            { "published", n => { Published = n.GetBoolValue(); } },
            { "roles", n => { Roles = n.GetObjectValue<KClient.Models.DashboardRestApi.Get_list.Role>(KClient.Models.DashboardRestApi.Get_list.Role.CreateFromDiscriminatorValue); } },
            { "slug", n => { Slug = n.GetStringValue(); } },
            { "status", n => { Status = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "tags", n => { Tags = n.GetObjectValue<KClient.Models.DashboardRestApi.Get_list.Tag>(KClient.Models.DashboardRestApi.Get_list.Tag.CreateFromDiscriminatorValue); } },
            { "thumbnail_url", n => { ThumbnailUrl = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "url", n => { Url = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("certification_details", CertificationDetails);
        writer.WriteStringValue("certified_by", CertifiedBy);
        writer.WriteObjectValue<KClient.Models.DashboardRestApi.Get_list.User>("changed_by", ChangedBy);
        writer.WriteObjectValue<KClient.Models.DashboardRestApi.Get_list.User1>("created_by", CreatedBy);
        writer.WriteStringValue("css", Css);
        writer.WriteStringValue("dashboard_title", DashboardTitle);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteObjectValue<KClient.Models.DashboardRestApi.Get_list.User2>("owners", Owners);
        writer.WriteStringValue("position_json", PositionJson);
        writer.WriteBoolValue("published", Published);
        writer.WriteObjectValue<KClient.Models.DashboardRestApi.Get_list.Role>("roles", Roles);
        writer.WriteStringValue("slug", Slug);
        writer.WriteObjectValue<KClient.Models.DashboardRestApi.Get_list.Tag>("tags", Tags);
        writer.WriteAdditionalData(AdditionalData);
    }
}
