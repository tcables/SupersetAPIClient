
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Saved_query;

[Obsolete("This class is obsolete. Use Saved_queryDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Saved_queryResponse : Saved_query.Saved_queryDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Saved_query.Saved_queryResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Saved_query.Saved_queryResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Saved_query.Saved_queryResponse();
    }
}
