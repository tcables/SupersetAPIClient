
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class UserResponseSchema : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The email property</summary>
    public string Email { get; set; }

    /// <summary>The first_name property</summary>
    public string FirstName { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The is_active property</summary>
    public bool? IsActive { get; set; }
    /// <summary>The is_anonymous property</summary>
    public bool? IsAnonymous { get; set; }
    /// <summary>The last_name property</summary>
    public string LastName { get; set; }

    /// <summary>The username property</summary>
    public string Username { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.UserResponseSchema"/> and sets the default values.
    /// </summary>
    public UserResponseSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.UserResponseSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.UserResponseSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.UserResponseSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "email", n => { Email = n.GetStringValue(); } },
            { "first_name", n => { FirstName = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "is_active", n => { IsActive = n.GetBoolValue(); } },
            { "is_anonymous", n => { IsAnonymous = n.GetBoolValue(); } },
            { "last_name", n => { LastName = n.GetStringValue(); } },
            { "username", n => { Username = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("email", Email);
        writer.WriteStringValue("first_name", FirstName);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("is_active", IsActive);
        writer.WriteBoolValue("is_anonymous", IsAnonymous);
        writer.WriteStringValue("last_name", LastName);
        writer.WriteStringValue("username", Username);
        writer.WriteAdditionalData(AdditionalData);
    }
}
