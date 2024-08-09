
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Available_domains;

[Obsolete("This class is obsolete. Use Available_domainsGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Available_domainsResponse : Available_domains.Available_domainsGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Available_domains.Available_domainsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Available_domains.Available_domainsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Available_domains.Available_domainsResponse();
    }
}
