
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Item.Ssh_tunnel;

[Obsolete("This class is obsolete. Use Ssh_tunnelDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Ssh_tunnelResponse : Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.Item.Ssh_tunnel.Ssh_tunnelResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Item.Ssh_tunnel.Ssh_tunnelResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item.Ssh_tunnel.Ssh_tunnelResponse();
    }
}
