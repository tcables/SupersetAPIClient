
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.TagRestApi.Get;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.TagRestApi.Get.User1? ChangedBy { get; set; }
#nullable restore
#else
    public KClient.Models.TagRestApi.Get.User1 ChangedBy { get; set; }
#endif
    /// <summary>The changed_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? ChangedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode ChangedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KClient.Models.TagRestApi.Get.User? CreatedBy { get; set; }
#nullable restore
#else
    public KClient.Models.TagRestApi.Get.User CreatedBy { get; set; }
#endif
    /// <summary>The created_on_delta_humanized property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? CreatedOnDeltaHumanized { get; private set; }
#nullable restore
#else
    public UntypedNode CreatedOnDeltaHumanized { get; private set; }
#endif
    /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Description { get; set; }
#nullable restore
#else
    public string Description { get; set; }
#endif
    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public UntypedNode? Type { get; set; }
#nullable restore
#else
    public UntypedNode Type { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.TagRestApi.Get.Get"/> and sets the default values.
    /// </summary>
    public Get()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.TagRestApi.Get.Get"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.TagRestApi.Get.Get CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.TagRestApi.Get.Get();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "changed_by", n => { ChangedBy = n.GetObjectValue<KClient.Models.TagRestApi.Get.User1>(KClient.Models.TagRestApi.Get.User1.CreateFromDiscriminatorValue); } },
            { "changed_on_delta_humanized", n => { ChangedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "created_by", n => { CreatedBy = n.GetObjectValue<KClient.Models.TagRestApi.Get.User>(KClient.Models.TagRestApi.Get.User.CreateFromDiscriminatorValue); } },
            { "created_on_delta_humanized", n => { CreatedOnDeltaHumanized = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            { "description", n => { Description = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "type", n => { Type = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.TagRestApi.Get.User1>("changed_by", ChangedBy);
        writer.WriteObjectValue<KClient.Models.TagRestApi.Get.User>("created_by", CreatedBy);
        writer.WriteStringValue("description", Description);
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<UntypedNode>("type", Type);
        writer.WriteAdditionalData(AdditionalData);
    }
}
