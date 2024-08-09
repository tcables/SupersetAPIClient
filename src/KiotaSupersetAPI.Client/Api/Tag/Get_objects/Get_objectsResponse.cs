
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Get_objects;

[Obsolete("This class is obsolete. Use Get_objectsGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_objectsResponse : Tag.Get_objects.Get_objectsGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Tag.Get_objects.Get_objectsResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Tag.Get_objects.Get_objectsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Tag.Get_objects.Get_objectsResponse();
    }
}
