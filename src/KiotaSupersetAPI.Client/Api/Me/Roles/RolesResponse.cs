
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Me.Roles;

[Obsolete("This class is obsolete. Use RolesGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class RolesResponse : Me.Roles.RolesGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Me.Roles.RolesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Me.Roles.RolesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Me.Roles.RolesResponse();
    }
}
