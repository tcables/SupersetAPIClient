
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class EmbeddedDashboardResponseSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The allowed_domains property</summary>
    public List<string> AllowedDomains { get; set; }

    /// <summary>The changed_by property</summary>
    public KClient.Models.User1 ChangedBy { get; set; }

    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The dashboard_id property</summary>
    public string DashboardId { get; set; }

    /// <summary>The uuid property</summary>
    public string Uuid { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.EmbeddedDashboardResponseSchema"/> and sets the default values.
    /// </summary>
    public EmbeddedDashboardResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.EmbeddedDashboardResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.EmbeddedDashboardResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.EmbeddedDashboardResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "allowed_domains", n => { AllowedDomains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.User1>(KClient.Models.User1.CreateFromDiscriminatorValue); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "dashboard_id", n => { DashboardId = n.GetStringValue(); } },
            { "uuid", n => { Uuid = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfPrimitiveValues<string>("allowed_domains", AllowedDomains);
        writer.WriteObjectValue<KClient.Models.User1>("changed_by", ChangedBy);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteStringValue("dashboard_id", DashboardId);
        writer.WriteStringValue("uuid", Uuid);
        writer.WriteAdditionalData(AdditionalData);
    }
}
