
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Log;

[Obsolete("This class is obsolete. Use LogGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class LogResponse : KiotaSupersetAPI.Client.API.Log.LogGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="API.Log.LogResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new LogResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new LogResponse();
    }
}
