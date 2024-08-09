
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database;

[Obsolete("This class is obsolete. Use DatabaseGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class DatabaseResponse : Database.DatabaseGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.DatabaseResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Database.DatabaseResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Database.DatabaseResponse();
    }
}
