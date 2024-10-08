
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Test_connection;

[Obsolete("This class is obsolete. Use Test_connectionPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Test_connectionResponse : Database.Test_connection.Test_connectionPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.Test_connection.Test_connectionResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Test_connection.Test_connectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Test_connection.Test_connectionResponse();
    }
}
