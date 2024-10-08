
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.LogRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Get : IAdditionalDataHolder, IParsable
{
    /// <summary>The action property</summary>
    public string Action { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The dashboard_id property</summary>
    public int? DashboardId { get; set; }
    /// <summary>The dttm property</summary>
    public DateTimeOffset? Dttm { get; set; }
    /// <summary>The duration_ms property</summary>
    public int? DurationMs { get; set; }
    /// <summary>The json property</summary>
    public string Json { get; set; }

    /// <summary>The referrer property</summary>
    public string Referrer { get; set; }

    /// <summary>The slice_id property</summary>
    public int? SliceId { get; set; }
    /// <summary>The user property</summary>
    public Models.LogRestAPI.Get.User User { get; set; }

    /// <summary>The user_id property</summary>
    public int? UserId { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="Models.LogRestAPI.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.LogRestAPI.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.LogRestAPI.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.LogRestAPI.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "action", n => { Action = n.GetStringValue(); } },
            { "dashboard_id", n => { DashboardId = n.GetIntValue(); } },
            { "dttm", n => { Dttm = n.GetDateTimeOffsetValue(); } },
            { "duration_ms", n => { DurationMs = n.GetIntValue(); } },
            { "json", n => { Json = n.GetStringValue(); } },
            { "referrer", n => { Referrer = n.GetStringValue(); } },
            { "slice_id", n => { SliceId = n.GetIntValue(); } },
            { "user", n => { User = n.GetObjectValue<Models.LogRestAPI.Get.User>(Models.LogRestAPI.Get.User.CreateFromDiscriminatorValue); } },
            { "user_id", n => { UserId = n.GetIntValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("action", Action);
        writer.WriteIntValue("dashboard_id", DashboardId);
        writer.WriteDateTimeOffsetValue("dttm", Dttm);
        writer.WriteIntValue("duration_ms", DurationMs);
        writer.WriteStringValue("json", Json);
        writer.WriteStringValue("referrer", Referrer);
        writer.WriteIntValue("slice_id", SliceId);
        writer.WriteObjectValue<Models.LogRestAPI.Get.User>("user", User);
        writer.WriteIntValue("user_id", UserId);
        writer.WriteAdditionalData(AdditionalData);
    }
}
