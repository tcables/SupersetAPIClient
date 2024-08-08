
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class ChartCacheScreenshotResponseSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The cache key</summary>
    public string CacheKey { get; set; }

    /// <summary>The url to render the chart</summary>
    public string ChartUrl { get; set; }

    /// <summary>The url to fetch the screenshot</summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.ChartCacheScreenshotResponseSchema"/> and sets the default values.
    /// </summary>
    public ChartCacheScreenshotResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ChartCacheScreenshotResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.ChartCacheScreenshotResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.ChartCacheScreenshotResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "cache_key", n => { CacheKey = n.GetStringValue(); } },
            { "chart_url", n => { ChartUrl = n.GetStringValue(); } },
            { "image_url", n => { ImageUrl = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("cache_key", CacheKey);
        writer.WriteStringValue("chart_url", ChartUrl);
        writer.WriteStringValue("image_url", ImageUrl);
        writer.WriteAdditionalData(AdditionalData);
    }
}
