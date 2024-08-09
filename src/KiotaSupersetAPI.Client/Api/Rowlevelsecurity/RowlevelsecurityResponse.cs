
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Rowlevelsecurity;

[Obsolete("This class is obsolete. Use RowlevelsecurityDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class RowlevelsecurityResponse : Rowlevelsecurity.RowlevelsecurityDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.RowlevelsecurityResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Rowlevelsecurity.RowlevelsecurityResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Rowlevelsecurity.RowlevelsecurityResponse();
    }
}
