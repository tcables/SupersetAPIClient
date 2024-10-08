
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Explore.Form_data;

[Obsolete("This class is obsolete. Use Form_dataPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Form_dataResponse : Explore.Form_data.Form_dataPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Form_dataResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Form_data.Form_dataResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Form_data.Form_dataResponse();
    }
}
