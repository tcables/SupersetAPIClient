// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Embedded
{
    [Obsolete("This class is obsolete. Use EmbeddedDeleteResponse instead.")]
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class EmbeddedResponse : global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Embedded.EmbeddedDeleteResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Embedded.EmbeddedResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Embedded.EmbeddedResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Api.V1.Dashboard.Item.Embedded.EmbeddedResponse();
        }
    }
}
