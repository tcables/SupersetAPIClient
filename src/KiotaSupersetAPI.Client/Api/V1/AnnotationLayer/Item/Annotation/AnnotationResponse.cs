
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.AnnotationLayer.Item.Annotation;

[Obsolete("This class is obsolete. Use AnnotationDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class AnnotationResponse : KApi.AnnotationLayer.Item.Annotation.AnnotationDeleteResponse, IParsable
#pragma warning restore CS1591
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.AnnotationLayer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.AnnotationLayer.Item.Annotation.AnnotationResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.AnnotationLayer.Item.Annotation.AnnotationResponse();
    }
}
