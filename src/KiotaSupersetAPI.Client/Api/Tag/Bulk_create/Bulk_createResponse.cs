
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Bulk_create;

[Obsolete("This class is obsolete. Use Bulk_createPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Bulk_createResponse : Tag.Bulk_create.Bulk_createPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Tag.Bulk_create.Bulk_createResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Bulk_create.Bulk_createResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Bulk_create.Bulk_createResponse();
    }
}
