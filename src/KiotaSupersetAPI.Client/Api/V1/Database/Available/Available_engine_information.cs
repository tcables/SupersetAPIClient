
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Available;

/// <summary>
/// Dict with public properties form the DB Engine
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Available_engine_information : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Whether the engine supports SSH Tunnels</summary>
    public bool? DisableSshTunneling { get; set; }
    /// <summary>Whether the engine supports file uploads</summary>
    public bool? SupportsFileUpload { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Available.Available_engine_information"/> and sets the default values.
    /// </summary>
    public Available_engine_information()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Available.Available_engine_information"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Database.Available.Available_engine_information CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Database.Available.Available_engine_information();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "disable_ssh_tunneling", n => { DisableSshTunneling = n.GetBoolValue(); } },
            { "supports_file_upload", n => { SupportsFileUpload = n.GetBoolValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("disable_ssh_tunneling", DisableSshTunneling);
        writer.WriteBoolValue("supports_file_upload", SupportsFileUpload);
        writer.WriteAdditionalData(AdditionalData);
    }
}
