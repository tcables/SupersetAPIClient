
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.ChartRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The cache_timeout property</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>The certification_details property</summary>
    public string CertificationDetails { get; set; }

    /// <summary>The certified_by property</summary>
    public string CertifiedBy { get; set; }

    /// <summary>The changed_on_delta_humanized property</summary>
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }

    /// <summary>The dashboards property</summary>
    public Models.ChartRestAPI.Get.Dashboard Dashboards { get; set; }

    /// <summary>The description property</summary>
    public string Description { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>The owners property</summary>
    public Models.ChartRestAPI.Get.User Owners { get; set; }

    /// <summary>The params property</summary>
    public string Params { get; set; }

    /// <summary>The query_context property</summary>
    public string QueryContext { get; set; }

    /// <summary>The slice_name property</summary>
    public string SliceName { get; set; }

    /// <summary>The tags property</summary>
    public Models.ChartRestAPI.Get.Tag Tags { get; set; }

    /// <summary>The thumbnail_url property</summary>
    public UntypedNode ThumbnailUrl { get; private set; }

    /// <summary>The url property</summary>
    public UntypedNode Url { get; private set; }

    /// <summary>The viz_type property</summary>
    public string VizType { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.ChartRestAPI.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.ChartRestAPI.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.ChartRestAPI.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.ChartRestAPI.Get.Get();
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
            { "dashboards", n => { Dashboards = n.GetObjectValue<Models.ChartRestAPI.Get.Dashboard>(Models.ChartRestAPI.Get.Dashboard.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "owners", n => { Owners = n.GetObjectValue<Models.ChartRestAPI.Get.User>(Models.ChartRestAPI.Get.User.CreateFromDiscriminatorValue); } },
            { "params", n => { Params = n.GetStringValue(); } },
            { "query_context", n => { QueryContext = n.GetStringValue(); } },
            { "slice_name", n => { SliceName = n.GetStringValue(); } },
            { "tags", n => { Tags = n.GetObjectValue<Models.ChartRestAPI.Get.Tag>(Models.ChartRestAPI.Get.Tag.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<Models.ChartRestAPI.Get.Dashboard>("dashboards", Dashboards);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteObjectValue<Models.ChartRestAPI.Get.User>("owners", Owners);
        writer.WriteStringValue("params", Params);
        writer.WriteStringValue("query_context", QueryContext);
        writer.WriteStringValue("slice_name", SliceName);
        writer.WriteObjectValue<Models.ChartRestAPI.Get.Tag>("tags", Tags);
        writer.WriteStringValue("viz_type", VizType);
        writer.WriteAdditionalData(AdditionalData);
    }
}
