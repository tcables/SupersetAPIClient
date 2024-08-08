// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace KiotaSupersetAPI.Client.Api.V1.Async_event
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Async_eventGetResponse_result : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The channel_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChannelId { get; set; }
#nullable restore
#else
        public string ChannelId { get; set; }
#endif
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result_errors>? Errors { get; set; }
#nullable restore
#else
        public List<global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result_errors> Errors { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The job_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobId { get; set; }
#nullable restore
#else
        public string JobId { get; set; }
#endif
        /// <summary>The result_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultUrl { get; set; }
#nullable restore
#else
        public string ResultUrl { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The user_id property</summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result"/> and sets the default values.
        /// </summary>
        public Async_eventGetResponse_result()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "channel_id", n => { ChannelId = n.GetStringValue(); } },
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result_errors>(global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result_errors.CreateFromDiscriminatorValue)?.ToList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "job_id", n => { JobId = n.GetStringValue(); } },
                { "result_url", n => { ResultUrl = n.GetStringValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "user_id", n => { UserId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("channel_id", ChannelId);
            writer.WriteCollectionOfObjectValues<global::KiotaSupersetAPI.Client.Api.V1.Async_event.Async_eventGetResponse_result_errors>("errors", Errors);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("job_id", JobId);
            writer.WriteStringValue("result_url", ResultUrl);
            writer.WriteStringValue("status", Status);
            writer.WriteIntValue("user_id", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
