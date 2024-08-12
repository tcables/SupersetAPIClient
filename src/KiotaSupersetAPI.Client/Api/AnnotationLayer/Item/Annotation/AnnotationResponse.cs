
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer.Item.Annotation;

[Obsolete("This class is obsolete. Use AnnotationDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class AnnotationResponse : AnnotationLayer.Item.Annotation.AnnotationDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.AnnotationResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Annotation.AnnotationResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Annotation.AnnotationResponse();
    }
}
