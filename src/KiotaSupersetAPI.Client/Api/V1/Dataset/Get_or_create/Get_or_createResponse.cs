
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Dataset.Get_or_create;

[Obsolete("This class is obsolete. Use Get_or_createPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Get_or_createResponse : KApi.Dataset.Get_or_create.Get_or_createPostResponse, IParsable
#pragma warning restore CS1591
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Get_or_create.Get_or_createResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Dataset.Get_or_create.Get_or_createResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Dataset.Get_or_create.Get_or_createResponse();
    }
}
