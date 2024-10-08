
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Css_template;

[Obsolete("This class is obsolete. Use Css_templateDeleteResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Css_templateResponse : Css_template.Css_templateDeleteResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Css_template.Css_templateResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Css_template.Css_templateResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Css_template.Css_templateResponse();
    }
}
