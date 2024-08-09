
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Explore.Form_data;

[Obsolete("This class is obsolete. Use Form_dataPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Form_dataResponse : KApi.Explore.Form_data.Form_dataPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.Form_data.Form_dataResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Explore.Form_data.Form_dataResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Explore.Form_data.Form_dataResponse();
    }
}
