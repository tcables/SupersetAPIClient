
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Query.Updated_since;

[Obsolete("This class is obsolete. Use Updated_sinceGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Updated_sinceResponse : Query.Updated_since.Updated_sinceGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Query.Updated_since.Updated_sinceResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Updated_since.Updated_sinceResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Updated_since.Updated_sinceResponse();
    }
}
