
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Saved_query.Import;

[Obsolete("This class is obsolete. Use ImportPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class ImportResponse : Saved_query.Import.ImportPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Saved_query.Import.ImportResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Saved_query.Import.ImportResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Saved_query.Import.ImportResponse();
    }
}
