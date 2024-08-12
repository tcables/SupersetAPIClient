
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Validate_parameters;

[Obsolete("This class is obsolete. Use Validate_parametersPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
public partial class Validate_parametersResponse : Database.Validate_parameters.Validate_parametersPostResponse, IParsable
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.Validate_parameters.Validate_parametersResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new Validate_parameters.Validate_parametersResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Validate_parameters.Validate_parametersResponse();
    }
}
