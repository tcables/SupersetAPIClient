
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Security.Login;

[GeneratedCode("Kiota", "1.16.0")]
public partial class LoginPostRequestBody : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The password for authentication</summary>
    public string Password { get; set; }

    /// <summary>Choose an authentication provider</summary>
    public KApi.Security.Login.LoginPostRequestBody_provider? Provider { get; set; }
    /// <summary>If true a refresh token is provided also</summary>
    public bool? Refresh { get; set; }
    /// <summary>The username for authentication</summary>
    public string Username { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KApi.Security.Login.LoginPostRequestBody"/> and sets the default values.
    /// </summary>
    public LoginPostRequestBody()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Security.Login.LoginPostRequestBody"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Security.Login.LoginPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Security.Login.LoginPostRequestBody();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "password", n => { Password = n.GetStringValue(); } },
            { "provider", n => { Provider = n.GetEnumValue<KApi.Security.Login.LoginPostRequestBody_provider>(); } },
            { "refresh", n => { Refresh = n.GetBoolValue(); } },
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
        writer.WriteStringValue("password", Password);
        writer.WriteEnumValue<KApi.Security.Login.LoginPostRequestBody_provider>("provider", Provider);
        writer.WriteBoolValue("refresh", Refresh);
        writer.WriteStringValue("username", Username);
        writer.WriteAdditionalData(AdditionalData);
    }
}
