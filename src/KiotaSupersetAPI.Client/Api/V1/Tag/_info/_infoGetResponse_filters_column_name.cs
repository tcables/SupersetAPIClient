
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Tag._info;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class _infoGetResponse_filters_column_name : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The filter name. Will be translated by babel</summary>
    public string Name { get; set; }

    /// <summary>The filter operation key to use on list filters</summary>
    public string Operator { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KApi.Tag._info._infoGetResponse_filters_column_name"/> and sets the default values.
    /// </summary>
    public _infoGetResponse_filters_column_name()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Tag._info._infoGetResponse_filters_column_name"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Tag._info._infoGetResponse_filters_column_name CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Tag._info._infoGetResponse_filters_column_name();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "name", n => { Name = n.GetStringValue(); } },
            { "operator", n => { Operator = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("name", Name);
        writer.WriteStringValue("operator", Operator);
        writer.WriteAdditionalData(AdditionalData);
    }
}
