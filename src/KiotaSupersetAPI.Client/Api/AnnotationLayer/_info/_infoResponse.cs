
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer._info;

[Obsolete("This class is obsolete. Use _infoGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class _infoResponse : KApi.AnnotationLayer._info._infoGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer._info._infoResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.AnnotationLayer._info._infoResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.AnnotationLayer._info._infoResponse();
    }
}
