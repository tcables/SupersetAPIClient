// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.ReportExecutionLogRestApi
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Get_list : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The end_dttm property</summary>
        public DateTimeOffset? EndDttm { get; set; }
        /// <summary>The error_message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage { get; set; }
#nullable restore
#else
        public string ErrorMessage { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The scheduled_dttm property</summary>
        public DateTimeOffset? ScheduledDttm { get; set; }
        /// <summary>The start_dttm property</summary>
        public DateTimeOffset? StartDttm { get; set; }
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The uuid property</summary>
        public Guid? Uuid { get; set; }
        /// <summary>The value property</summary>
        public double? Value { get; set; }
        /// <summary>The value_row_json property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueRowJson { get; set; }
#nullable restore
#else
        public string ValueRowJson { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Models.ReportExecutionLogRestApi.Get_list"/> and sets the default values.
        /// </summary>
        public Get_list()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KiotaSupersetAPI.Client.Models.ReportExecutionLogRestApi.Get_list"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KiotaSupersetAPI.Client.Models.ReportExecutionLogRestApi.Get_list CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KiotaSupersetAPI.Client.Models.ReportExecutionLogRestApi.Get_list();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end_dttm", n => { EndDttm = n.GetDateTimeOffsetValue(); } },
                { "error_message", n => { ErrorMessage = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "scheduled_dttm", n => { ScheduledDttm = n.GetDateTimeOffsetValue(); } },
                { "start_dttm", n => { StartDttm = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "uuid", n => { Uuid = n.GetGuidValue(); } },
                { "value", n => { Value = n.GetDoubleValue(); } },
                { "value_row_json", n => { ValueRowJson = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("end_dttm", EndDttm);
            writer.WriteStringValue("error_message", ErrorMessage);
            writer.WriteIntValue("id", Id);
            writer.WriteDateTimeOffsetValue("scheduled_dttm", ScheduledDttm);
            writer.WriteDateTimeOffsetValue("start_dttm", StartDttm);
            writer.WriteStringValue("state", State);
            writer.WriteGuidValue("uuid", Uuid);
            writer.WriteDoubleValue("value", Value);
            writer.WriteStringValue("value_row_json", ValueRowJson);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
