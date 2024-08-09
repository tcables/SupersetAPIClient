
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.Item._openapi;

[Obsolete("This class is obsolete. Use _openapiGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class _openapiResponse : KClient.Api.Item._openapi._openapiGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Api.Item._openapi._openapiResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KClient.Api.Item._openapi._openapiResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Api.Item._openapi._openapiResponse();
    }
}
