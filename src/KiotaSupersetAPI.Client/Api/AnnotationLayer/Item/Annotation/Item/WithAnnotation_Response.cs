
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer.Item.Annotation.Item;

[Obsolete("This class is obsolete. Use WithAnnotation_DeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithAnnotation_Response : AnnotationLayer.Item.Annotation.Item.WithAnnotation_DeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new AnnotationLayer.Item.Annotation.Item.WithAnnotation_Response();
    }
}
