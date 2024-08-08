
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Assets.Import
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ImportPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>upload file (ZIP or JSON)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bundle { get; set; }
#nullable restore
#else
        public string Bundle { get; set; }
#endif
        /// <summary>JSON map of passwords for each featured database in the ZIP file. If the ZIP includes a database config in the path `databases/MyDatabase.yaml`, the password should be provided in the following format: `{&quot;databases/MyDatabase.yaml&quot;: &quot;my_password&quot;}`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Passwords { get; set; }
#nullable restore
#else
        public string Passwords { get; set; }
#endif
        /// <summary>JSON map of passwords for each ssh_tunnel associated to a featured database in the ZIP file. If the ZIP includes a ssh_tunnel config in the path `databases/MyDatabase.yaml`, the password should be provided in the following format: `{&quot;databases/MyDatabase.yaml&quot;: &quot;my_password&quot;}`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshTunnelPasswords { get; set; }
#nullable restore
#else
        public string SshTunnelPasswords { get; set; }
#endif
        /// <summary>JSON map of private_key_passwords for each ssh_tunnel associated to a featured database in the ZIP file. If the ZIP includes a ssh_tunnel config in the path `databases/MyDatabase.yaml`, the private_key should be provided in the following format: `{&quot;databases/MyDatabase.yaml&quot;: &quot;my_private_key_password&quot;}`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshTunnelPrivateKeyPasswords { get; set; }
#nullable restore
#else
        public string SshTunnelPrivateKeyPasswords { get; set; }
#endif
        /// <summary>JSON map of private_keys for each ssh_tunnel associated to a featured database in the ZIP file. If the ZIP includes a ssh_tunnel config in the path `databases/MyDatabase.yaml`, the private_key should be provided in the following format: `{&quot;databases/MyDatabase.yaml&quot;: &quot;my_private_key&quot;}`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SshTunnelPrivateKeys { get; set; }
#nullable restore
#else
        public string SshTunnelPrivateKeys { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KApi.Assets.Import.ImportPostRequestBody"/> and sets the default values.
        /// </summary>
        public ImportPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KApi.Assets.Import.ImportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KApi.Assets.Import.ImportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KApi.Assets.Import.ImportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bundle", n => { Bundle = n.GetStringValue(); } },
                { "passwords", n => { Passwords = n.GetStringValue(); } },
                { "ssh_tunnel_passwords", n => { SshTunnelPasswords = n.GetStringValue(); } },
                { "ssh_tunnel_private_key_passwords", n => { SshTunnelPrivateKeyPasswords = n.GetStringValue(); } },
                { "ssh_tunnel_private_keys", n => { SshTunnelPrivateKeys = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bundle", Bundle);
            writer.WriteStringValue("passwords", Passwords);
            writer.WriteStringValue("ssh_tunnel_passwords", SshTunnelPasswords);
            writer.WriteStringValue("ssh_tunnel_private_key_passwords", SshTunnelPrivateKeyPasswords);
            writer.WriteStringValue("ssh_tunnel_private_keys", SshTunnelPrivateKeys);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
