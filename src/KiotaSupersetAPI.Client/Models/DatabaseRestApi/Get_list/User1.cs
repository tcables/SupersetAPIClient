
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DatabaseRestApi.Get_list;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class User1 : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The first_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? FirstName { get; set; }
#nullable restore
#else
    public string FirstName { get; set; }
#endif
    /// <summary>The last_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? LastName { get; set; }
#nullable restore
#else
    public string LastName { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseRestApi.Get_list.User1"/> and sets the default values.
    /// </summary>
    public User1()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseRestApi.Get_list.User1"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseRestApi.Get_list.User1 CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseRestApi.Get_list.User1();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "first_name", n => { FirstName = n.GetStringValue(); } },
            { "last_name", n => { LastName = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("first_name", FirstName);
        writer.WriteStringValue("last_name", LastName);
        writer.WriteAdditionalData(AdditionalData);
    }
}
