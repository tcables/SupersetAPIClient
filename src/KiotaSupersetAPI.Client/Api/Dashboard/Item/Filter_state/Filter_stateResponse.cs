
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dashboard.Item.Filter_state;

[Obsolete("This class is obsolete. Use Filter_statePostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Filter_stateResponse : Dashboard.Item.Filter_state.Filter_statePostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Dashboard.Item.Filter_state.Filter_stateResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Filter_stateResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Filter_stateResponse();
    }
}
