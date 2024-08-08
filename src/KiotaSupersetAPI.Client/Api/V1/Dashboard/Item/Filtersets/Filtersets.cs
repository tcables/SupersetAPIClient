
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Filtersets;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Filtersets : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>A description field of the filter set</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>metadata of the filter set</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? JsonMetadata { get; set; }
#nullable restore
#else
    public string JsonMetadata { get; set; }
#endif
    /// <summary>Name of the Filter set</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>A description field of the filter set</summary>
    public int? OwnerId { get; set; }
    /// <summary>the Type of the owner ( Dashboard/User)</summary>
    public int? OwnerType { get; set; }
    /// <summary>JSON schema defining the needed parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Parameters { get; set; }
#nullable restore
#else
    public UntypedNode Parameters { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dashboard.Item.Filtersets.Filtersets"/> and sets the default values.
    /// </summary>
    public Filtersets()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.Item.Filtersets.Filtersets"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Dashboard.Item.Filtersets.Filtersets CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Dashboard.Item.Filtersets.Filtersets();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "description", n => { Description = n.GetStringValue(); } },
            { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "owner_id", n => { OwnerId = n.GetIntValue(); } },
            { "owner_type", n => { OwnerType = n.GetIntValue(); } },
            { "parameters", n => { Parameters = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("description", Description);
        writer.WriteStringValue("json_metadata", JsonMetadata);
        writer.WriteStringValue("name", Name);
        writer.WriteIntValue("owner_id", OwnerId);
        writer.WriteIntValue("owner_type", OwnerType);
        writer.WriteObjectValue<UntypedNode>("parameters", Parameters);
        writer.WriteAdditionalData(AdditionalData);
    }
}
