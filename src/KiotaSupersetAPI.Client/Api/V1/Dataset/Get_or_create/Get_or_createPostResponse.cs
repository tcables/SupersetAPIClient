// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using Api = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Get_or_createPostResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse_result? Result { get; set; }
#nullable restore
#else
        public global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse_result Result { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse"/> and sets the default values.
        /// </summary>
        public Get_or_createPostResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "result", n => { Result = n.GetObjectValue<global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse_result>(global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse_result.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::KiotaSupersetAPI.Client.Api.V1.Dataset.Get_or_create.Get_or_createPostResponse_result>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
