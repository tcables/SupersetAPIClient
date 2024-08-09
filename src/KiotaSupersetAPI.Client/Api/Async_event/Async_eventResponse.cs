
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Async_event;

[Obsolete("This class is obsolete. Use Async_eventGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Async_eventResponse : KApi.Async_event.Async_eventGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Async_event.Async_eventResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Async_event.Async_eventResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Async_event.Async_eventResponse();
    }
}
