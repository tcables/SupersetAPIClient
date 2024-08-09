
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models.TagRestAPI.Get;

[GeneratedCode("Kiota", "1.16.0")]
public partial class User : IAdditionalDataHolder, IParsable
{
    /// <summary>The active property</summary>
    public bool? Active { get; set; }
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The changed_on property</summary>
    public DateTimeOffset? ChangedOn { get; set; }
    /// <summary>The created_on property</summary>
    public DateTimeOffset? CreatedOn { get; set; }
    /// <summary>The email property</summary>
    public string Email { get; set; }

    /// <summary>The fail_login_count property</summary>
    public int? FailLoginCount { get; set; }
    /// <summary>The first_name property</summary>
    public string FirstName { get; set; }

    /// <summary>The id property</summary>
    public int? Id { get; set; }
    /// <summary>The last_login property</summary>
    public DateTimeOffset? LastLogin { get; set; }
    /// <summary>The last_name property</summary>
    public string LastName { get; set; }

    /// <summary>The login_count property</summary>
    public int? LoginCount { get; set; }
    /// <summary>The password property</summary>
    public string Password { get; set; }

    /// <summary>The username property</summary>
    public string Username { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.TagRestAPI.Get.User"/> and sets the default values.
    /// </summary>
    public User()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.TagRestAPI.Get.User"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.TagRestAPI.Get.User CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.TagRestAPI.Get.User();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "active", n => { Active = n.GetBoolValue(); } },
            { "changed_on", n => { ChangedOn = n.GetDateTimeOffsetValue(); } },
            { "created_on", n => { CreatedOn = n.GetDateTimeOffsetValue(); } },
            { "email", n => { Email = n.GetStringValue(); } },
            { "fail_login_count", n => { FailLoginCount = n.GetIntValue(); } },
            { "first_name", n => { FirstName = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "last_login", n => { LastLogin = n.GetDateTimeOffsetValue(); } },
            { "last_name", n => { LastName = n.GetStringValue(); } },
            { "login_count", n => { LoginCount = n.GetIntValue(); } },
            { "password", n => { Password = n.GetStringValue(); } },
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
        writer.WriteBoolValue("active", Active);
        writer.WriteDateTimeOffsetValue("changed_on", ChangedOn);
        writer.WriteDateTimeOffsetValue("created_on", CreatedOn);
        writer.WriteStringValue("email", Email);
        writer.WriteIntValue("fail_login_count", FailLoginCount);
        writer.WriteStringValue("first_name", FirstName);
        writer.WriteIntValue("id", Id);
        writer.WriteDateTimeOffsetValue("last_login", LastLogin);
        writer.WriteStringValue("last_name", LastName);
        writer.WriteIntValue("login_count", LoginCount);
        writer.WriteStringValue("password", Password);
        writer.WriteStringValue("username", Username);
        writer.WriteAdditionalData(AdditionalData);
    }
}
