
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Get_or_create;

[Obsolete("This class is obsolete. Use Get_or_createPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_or_createResponse : Dataset.Get_or_create.Get_or_createPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dataset.Get_or_create.Get_or_createResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Dataset.Get_or_create.Get_or_createResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Dataset.Get_or_create.Get_or_createResponse();
    }
}
