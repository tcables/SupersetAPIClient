
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Item._openapi;

[Obsolete("This class is obsolete. Use _openapiGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class _openapiResponse : _openapiGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="API.Item._openapi._openapiResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Item._openapi._openapiResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Item._openapi._openapiResponse();
    }
}
