
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Dashboard_PutResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The id property</summary>
    public double? Id { get; set; }
    /// <summary>The last_modified_time property</summary>
    public double? LastModifiedTime { get; set; }
    /// <summary>The result property</summary>
    public Models.DashboardRestAPI.Put Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Dashboard.Item.Dashboard_PutResponse"/> and sets the default values.
    /// </summary>
    public Dashboard_PutResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Dashboard_PutResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Dashboard.Item.Dashboard_PutResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Dashboard_PutResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetDoubleValue(); } },
            { "last_modified_time", n => { LastModifiedTime = n.GetDoubleValue(); } },
            { "result", n => { Result = n.GetObjectValue<Models.DashboardRestAPI.Put>(Models.DashboardRestAPI.Put.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteDoubleValue("id", Id);
        writer.WriteDoubleValue("last_modified_time", LastModifiedTime);
        writer.WriteObjectValue<Models.DashboardRestAPI.Put>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
