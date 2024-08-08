
using System;
using System.CodeDom.Compiler;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Tag.Bulk_create;

[Obsolete("This class is obsolete. Use Bulk_createPostResponse instead.")]
[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Bulk_createResponse : KApi.Tag.Bulk_create.Bulk_createPostResponse, IParsable
#pragma warning restore CS1591
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Tag.Bulk_create.Bulk_createResponse"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new KApi.Tag.Bulk_create.Bulk_createResponse CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Tag.Bulk_create.Bulk_createResponse();
    }
}
