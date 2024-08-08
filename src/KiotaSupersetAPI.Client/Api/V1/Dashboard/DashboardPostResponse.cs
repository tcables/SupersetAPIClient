
using KiotaSupersetAPI.Client.Models.DashboardRestApi;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class DashboardPostResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id property</summary>
        public double? Id { get; set; }
        /// <summary>The result property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KClient.Models.DashboardRestApi.Post? Result { get; set; }
#nullable restore
#else
        public KClient.Models.DashboardRestApi.Post Result { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KApi.Dashboard.DashboardPostResponse"/> and sets the default values.
        /// </summary>
        public DashboardPostResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KApi.Dashboard.DashboardPostResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KApi.Dashboard.DashboardPostResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KApi.Dashboard.DashboardPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetDoubleValue(); } },
                { "result", n => { Result = n.GetObjectValue<KClient.Models.DashboardRestApi.Post>(KClient.Models.DashboardRestApi.Post.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("id", Id);
            writer.WriteObjectValue<KClient.Models.DashboardRestApi.Post>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
