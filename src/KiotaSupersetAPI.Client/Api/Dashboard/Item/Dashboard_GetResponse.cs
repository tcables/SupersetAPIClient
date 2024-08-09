
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Dashboard_GetResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The result property</summary>
    public KClient.Models.DashboardGetResponseSchema Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KApi.Dashboard.Item.Dashboard_GetResponse"/> and sets the default values.
    /// </summary>
    public Dashboard_GetResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.Item.Dashboard_GetResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Dashboard.Item.Dashboard_GetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Dashboard.Item.Dashboard_GetResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "result", n => { Result = n.GetObjectValue<KClient.Models.DashboardGetResponseSchema>(KClient.Models.DashboardGetResponseSchema.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.DashboardGetResponseSchema>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
