
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Chart.Item.Favorites;

[GeneratedCode("Kiota", "1.16.0")]
public partial class FavoritesDeleteResponse : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The result property</summary>
    public Favorites.FavoritesDeleteResponse_result Result { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Chart.Item.Favorites.FavoritesDeleteResponse"/> and sets the default values.
    /// </summary>
    public FavoritesDeleteResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Chart.Item.Favorites.FavoritesDeleteResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Chart.Item.Favorites.FavoritesDeleteResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Favorites.FavoritesDeleteResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "result", n => { Result = n.GetObjectValue<Chart.Item.Favorites.FavoritesDeleteResponse_result>(Chart.Item.Favorites.FavoritesDeleteResponse_result.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<Chart.Item.Favorites.FavoritesDeleteResponse_result>("result", Result);
        writer.WriteAdditionalData(AdditionalData);
    }
}
