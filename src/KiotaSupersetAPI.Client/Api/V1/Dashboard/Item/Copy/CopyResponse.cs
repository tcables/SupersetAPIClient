// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Copy
{
    [Obsolete("This class is obsolete. Use CopyPostResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class CopyResponse : global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Copy.CopyPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Copy.CopyResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Copy.CopyResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Copy.CopyResponse();
        }
    }
}
