
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Security.Login;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class LoginPostResponse : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>The access_token property</summary>
    public string AccessToken { get; set; }

    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The refresh_token property</summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KApi.Security.Login.LoginPostResponse"/> and sets the default values.
    /// </summary>
    public LoginPostResponse()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Security.Login.LoginPostResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Security.Login.LoginPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Security.Login.LoginPostResponse();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "access_token", n => { AccessToken = n.GetStringValue(); } },
            { "refresh_token", n => { RefreshToken = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("access_token", AccessToken);
        writer.WriteStringValue("refresh_token", RefreshToken);
        writer.WriteAdditionalData(AdditionalData);
    }
}
