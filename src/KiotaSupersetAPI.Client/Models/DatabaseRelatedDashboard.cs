
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DatabaseRelatedDashboard : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The json_metadata property</summary>
    public KClient.Models.DatabaseRelatedDashboard_json_metadata JsonMetadata { get; set; }

    /// <summary>The slug property</summary>
    public string Slug { get; set; }

    /// <summary>The title property</summary>
    public string Title { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseRelatedDashboard"/> and sets the default values.
    /// </summary>
    public DatabaseRelatedDashboard()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseRelatedDashboard"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseRelatedDashboard CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseRelatedDashboard();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetIntValue(); } },
            { "json_metadata", n => { JsonMetadata = n.GetObjectValue<KClient.Models.DatabaseRelatedDashboard_json_metadata>(KClient.Models.DatabaseRelatedDashboard_json_metadata.CreateFromDiscriminatorValue); } },
            { "slug", n => { Slug = n.GetStringValue(); } },
            { "title", n => { Title = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteIntValue("id", Id);
        writer.WriteObjectValue<KClient.Models.DatabaseRelatedDashboard_json_metadata>("json_metadata", JsonMetadata);
        writer.WriteStringValue("slug", Slug);
        writer.WriteStringValue("title", Title);
        writer.WriteAdditionalData(AdditionalData);
    }
}
