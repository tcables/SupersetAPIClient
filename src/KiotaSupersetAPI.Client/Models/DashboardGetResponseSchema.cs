
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DashboardGetResponseSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Details of the certification</summary>
    public string CertificationDetails { get; set; }

    /// <summary>Person or group that has certified this dashboard</summary>
    public string CertifiedBy { get; set; }

    /// <summary>The changed_by property</summary>
    public KClient.Models.User ChangedBy { get; set; }

    /// <summary>The changed_by_name property</summary>
    public string ChangedByName { get; set; }

    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The changed_on_delta_humanized property</summary>
    public string ChangedOnDeltaHumanized { get; set; }

    /// <summary>The charts property</summary>
    public List<string> Charts { get; set; }

    /// <summary>Override CSS for the dashboard.</summary>
    public string Css { get; set; }

    /// <summary>A title for the dashboard.</summary>
    public string DashboardTitle { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>This JSON object is generated dynamically when clicking the save or overwrite button in the dashboard view. It is exposed here for reference and for power users who may want to alter  specific parameters.</summary>
    public string JsonMetadata { get; set; }

    /// <summary>The owners property</summary>
    public List<KClient.Models.User> Owners { get; set; }

    /// <summary>This json object describes the positioning of the widgets in the dashboard. It is dynamically generated when adjusting the widgets size and positions by using drag &amp; drop in the dashboard view</summary>
    public string PositionJson { get; set; }

    /// <summary>The published property</summary>
    public bool? Published { get; set; }
    /// <summary>The roles property</summary>
    public List<KClient.Models.Roles> Roles { get; set; }

    /// <summary>The slug property</summary>
    public string Slug { get; set; }

    /// <summary>The tags property</summary>
    public List<KClient.Models.Tag1> Tags { get; set; }

    /// <summary>The thumbnail_url property</summary>
    public string ThumbnailUrl { get; set; }

    /// <summary>The url property</summary>
    public string Url { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DashboardGetResponseSchema"/> and sets the default values.
    /// </summary>
    public DashboardGetResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DashboardGetResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DashboardGetResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DashboardGetResponseSchema();
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
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.User>(KClient.Models.User.CreateFromDiscriminatorValue); } },
            { "changed_by_name", n => { ChangedByName = n.GetStringValue(); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetStringValue(); } },
            { "charts", n => { Charts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "css", n => { Css = n.GetStringValue(); } },
            { "dashboard_title", n => { DashboardTitle = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
            { "owners", n => { Owners = n.GetCollectionOfObjectValues<KClient.Models.User>(KClient.Models.User.CreateFromDiscriminatorValue)?.ToList(); } },
            { "position_json", n => { PositionJson = n.GetStringValue(); } },
            { "published", n => { Published = n.GetBoolValue(); } },
            { "roles", n => { Roles = n.GetCollectionOfObjectValues<KClient.Models.Roles>(KClient.Models.Roles.CreateFromDiscriminatorValue)?.ToList(); } },
            { "slug", n => { Slug = n.GetStringValue(); } },
            { "tags", n => { Tags = n.GetCollectionOfObjectValues<KClient.Models.Tag1>(KClient.Models.Tag1.CreateFromDiscriminatorValue)?.ToList(); } },
            { "thumbnail_url", n => { ThumbnailUrl = n.GetStringValue(); } },
            { "url", n => { Url = n.GetStringValue(); } },
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
        writer.WriteObjectValue<KClient.Models.User>("changed_by", ChangedBy);
        writer.WriteStringValue("changed_by_name", ChangedByName);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteStringValue("changed_on_delta_humanized", ChangedOnDeltaHumanized);
        writer.WriteCollectionOfPrimitiveValues<string>("charts", Charts);
        writer.WriteStringValue("css", Css);
        writer.WriteStringValue("dashboard_title", DashboardTitle);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteCollectionOfObjectValues<KClient.Models.User>("owners", Owners);
        writer.WriteStringValue("position_json", PositionJson);
        writer.WriteBoolValue("published", Published);
        writer.WriteCollectionOfObjectValues<KClient.Models.Roles>("roles", Roles);
        writer.WriteStringValue("slug", Slug);
        writer.WriteCollectionOfObjectValues<KClient.Models.Tag1>("tags", Tags);
        writer.WriteStringValue("thumbnail_url", ThumbnailUrl);
        writer.WriteStringValue("url", Url);
        writer.WriteAdditionalData(AdditionalData);
    }
}
