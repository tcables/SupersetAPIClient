
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;

namespace KiotaSupersetAPI.Client.API.Async_event;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Async_eventGetResponse_result : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>The channel_id property</summary>
    public string ChannelId { get; set; }

    /// <summary>The errors property</summary>
    public List<KApi.Async_event.Async_eventGetResponse_result_errors> Errors { get; set; }

    /// <summary>The id property</summary>
    public string Id { get; set; }

    /// <summary>The job_id property</summary>
    public string JobId { get; set; }

    /// <summary>The result_url property</summary>
    public string ResultUrl { get; set; }

    /// <summary>The status property</summary>
    public string Status { get; set; }

    /// <summary>The user_id property</summary>
    public int? UserId { get; set; }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Async_event.Async_eventGetResponse_result"/> and sets the default values.
    /// </summary>
    public Async_eventGetResponse_result()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Async_event.Async_eventGetResponse_result"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Async_event.Async_eventGetResponse_result CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Async_event.Async_eventGetResponse_result();
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
            { "errors", n => { Errors = n.GetCollectionOfObjectValues<KApi.Async_event.Async_eventGetResponse_result_errors>(KApi.Async_event.Async_eventGetResponse_result_errors.CreateFromDiscriminatorValue)?.ToList(); } },
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
        writer.WriteCollectionOfObjectValues<KApi.Async_event.Async_eventGetResponse_result_errors>("errors", Errors);
        writer.WriteStringValue("id", Id);
        writer.WriteStringValue("job_id", JobId);
        writer.WriteStringValue("result_url", ResultUrl);
        writer.WriteStringValue("status", Status);
        writer.WriteIntValue("user_id", UserId);
        writer.WriteAdditionalData(AdditionalData);
    }
}
