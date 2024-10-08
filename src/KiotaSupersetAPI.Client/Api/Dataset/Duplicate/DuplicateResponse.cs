
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Duplicate;

[Obsolete("This class is obsolete. Use DuplicatePostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class DuplicateResponse : Dataset.Duplicate.DuplicatePostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dataset.Duplicate.DuplicateResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Duplicate.DuplicateResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Duplicate.DuplicateResponse();
    }
}
