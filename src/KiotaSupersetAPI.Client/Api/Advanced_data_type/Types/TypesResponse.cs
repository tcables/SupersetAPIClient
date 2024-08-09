
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Advanced_data_type.Types;

[Obsolete("This class is obsolete. Use TypesGetResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class TypesResponse : Advanced_data_type.Types.TypesGetResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Advanced_data_type.Types.TypesResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Advanced_data_type.Types.TypesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Advanced_data_type.Types.TypesResponse();
    }
}
