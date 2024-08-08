
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class DatabaseSSHTunnel : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>SSH Tunnel ID (for updates)</summary>
    public int? Id { get; set; }
    /// <summary>The password property</summary>
    public string Password { get; set; }

    /// <summary>The private_key property</summary>
    public string PrivateKey { get; set; }

    /// <summary>The private_key_password property</summary>
    public string PrivateKeyPassword { get; set; }

    /// <summary>The server_address property</summary>
    public string ServerAddress { get; set; }

    /// <summary>The server_port property</summary>
    public int? ServerPort { get; set; }
    /// <summary>The username property</summary>
    public string Username { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseSSHTunnel"/> and sets the default values.
    /// </summary>
    public DatabaseSSHTunnel()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseSSHTunnel"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseSSHTunnel CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseSSHTunnel();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "id", n => { Id = n.GetIntValue(); } },
            { "password", n => { Password = n.GetStringValue(); } },
            { "private_key", n => { PrivateKey = n.GetStringValue(); } },
            { "private_key_password", n => { PrivateKeyPassword = n.GetStringValue(); } },
            { "server_address", n => { ServerAddress = n.GetStringValue(); } },
            { "server_port", n => { ServerPort = n.GetIntValue(); } },
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
        writer.WriteIntValue("id", Id);
        writer.WriteStringValue("password", Password);
        writer.WriteStringValue("private_key", PrivateKey);
        writer.WriteStringValue("private_key_password", PrivateKeyPassword);
        writer.WriteStringValue("server_address", ServerAddress);
        writer.WriteIntValue("server_port", ServerPort);
        writer.WriteStringValue("username", Username);
        writer.WriteAdditionalData(AdditionalData);
    }
}
