
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.AnnotationLayer;

[Obsolete("This class is obsolete. Use Annotation_layerDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Annotation_layerResponse : AnnotationLayer.Annotation_layerDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="AnnotationLayer.Annotation_layerResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new AnnotationLayer.Annotation_layerResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new AnnotationLayer.Annotation_layerResponse();
    }
}
