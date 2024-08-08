
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class ExplorePermalinkStateSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Chart form data</summary>
    public KClient.Models.ExplorePermalinkStateSchema_formData FormData { get; set; }

    /// <summary>URL Parameters</summary>
    public UntypedNode UrlParams { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ExplorePermalinkStateSchema"/> and sets the default values.
    /// </summary>
    public ExplorePermalinkStateSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ExplorePermalinkStateSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ExplorePermalinkStateSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ExplorePermalinkStateSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "formData", n => { FormData = n.GetObjectValue<KClient.Models.ExplorePermalinkStateSchema_formData>(KClient.Models.ExplorePermalinkStateSchema_formData.CreateFromDiscriminatorValue); } },
            { "urlParams", n => { UrlParams = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.ExplorePermalinkStateSchema_formData>("formData", FormData);
        writer.WriteObjectValue<UntypedNode>("urlParams", UrlParams);
        writer.WriteAdditionalData(AdditionalData);
    }
}
