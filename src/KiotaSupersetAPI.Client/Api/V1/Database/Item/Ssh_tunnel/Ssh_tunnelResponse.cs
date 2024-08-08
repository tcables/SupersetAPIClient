
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Ssh_tunnel;

[Obsolete("This class is obsolete. Use Ssh_tunnelDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Ssh_tunnelResponse : KApi.Database.Item.Ssh_tunnel.Ssh_tunnelDeleteResponse, IParsable
#pragma warning restore CS1591
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Database.Item.Ssh_tunnel.Ssh_tunnelResponse();
    }
}
