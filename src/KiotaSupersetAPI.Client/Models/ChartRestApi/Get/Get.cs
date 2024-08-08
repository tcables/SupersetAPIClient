
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ChartRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
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
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The dashboards property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ChartRestApi.Get.Dashboard? Dashboards { get; set; }
#nullable restore
#else
    public KClient.Models.ChartRestApi.Get.Dashboard Dashboards { get; set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.ChartRestApi.Get.User? Owners { get; set; }
#nullable restore
#else
    public KClient.Models.ChartRestApi.Get.User Owners { get; set; }
#endif
    /// <summary>The params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Params { get; set; }
#nullable restore
#else
    public string Params { get; set; }
#endif
    /// <summary>The query_context property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? QueryContext { get; set; }
#nullable restore
#else
    public string QueryContext { get; set; }
#endif
    /// <summary>The slice_name property</summary>
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
    public KClient.Models.ChartRestApi.Get.Tag? Tags { get; set; }
#nullable restore
#else
    public KClient.Models.ChartRestApi.Get.Tag Tags { get; set; }
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
    /// Instantiates a new <see cref="KClient.Models.ChartRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartRestApi.Get.Get();
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
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "dashboards", n => { Dashboards = n.GetObjectValue<KClient.Models.ChartRestApi.Get.Dashboard>(KClient.Models.ChartRestApi.Get.Dashboard.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "owners", n => { Owners = n.GetObjectValue<KClient.Models.ChartRestApi.Get.User>(KClient.Models.ChartRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "params", n => { Params = n.GetStringValue(); } },
            { "query_context", n => { QueryContext = n.GetStringValue(); } },
            { "slice_name", n => { SliceName = n.GetStringValue(); } },
            { "tags", n => { Tags = n.GetObjectValue<KClient.Models.ChartRestApi.Get.Tag>(KClient.Models.ChartRestApi.Get.Tag.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<KClient.Models.ChartRestApi.Get.Dashboard>("dashboards", Dashboards);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteObjectValue<KClient.Models.ChartRestApi.Get.User>("owners", Owners);
        writer.WriteStringValue("params", Params);
        writer.WriteStringValue("query_context", QueryContext);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteObjectValue<KClient.Models.ChartRestApi.Get.Tag>("tags", Tags);
        writer.WriteStringValue("viz_type", VizType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
