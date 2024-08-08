
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models.DashboardRestApi
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Put : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Details of the certification</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationDetails { get; set; }
#nullable restore
#else
        public string CertificationDetails { get; set; }
#endif
        /// <summary>Person or group that has certified this dashboard</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertifiedBy { get; set; }
#nullable restore
#else
        public string CertifiedBy { get; set; }
#endif
        /// <summary>Override CSS for the dashboard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Css { get; set; }
#nullable restore
#else
        public string Css { get; set; }
#endif
        /// <summary>A title for the dashboard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DashboardTitle { get; set; }
#nullable restore
#else
        public string DashboardTitle { get; set; }
#endif
        /// <summary>The external_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalUrl { get; set; }
#nullable restore
#else
        public string ExternalUrl { get; set; }
#endif
        /// <summary>The is_managed_externally property</summary>
        public bool? IsManagedExternally { get; set; }
        /// <summary>This JSON object is generated dynamically when clicking the save or overwrite button in the dashboard view. It is exposed here for reference and for power users who may want to alter  specific parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JsonMetadata { get; set; }
#nullable restore
#else
        public string JsonMetadata { get; set; }
#endif
        /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Owners { get; set; }
#nullable restore
#else
        public List<int?> Owners { get; set; }
#endif
        /// <summary>This json object describes the positioning of the widgets in the dashboard. It is dynamically generated when adjusting the widgets size and positions by using drag &amp; drop in the dashboard view</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PositionJson { get; set; }
#nullable restore
#else
        public string PositionJson { get; set; }
#endif
        /// <summary>Determines whether or not this dashboard is visible in the list of all dashboards.</summary>
        public bool? Published { get; set; }
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Roles { get; set; }
#nullable restore
#else
        public List<int?> Roles { get; set; }
#endif
        /// <summary>Unique identifying part for the web address of the dashboard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KClient.Models.DashboardRestApi.Put"/> and sets the default values.
        /// </summary>
        public Put()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KClient.Models.DashboardRestApi.Put"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KClient.Models.DashboardRestApi.Put CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KClient.Models.DashboardRestApi.Put();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "certification_details", n => { CertificationDetails = n.GetStringValue(); } },
                { "certified_by", n => { CertifiedBy = n.GetStringValue(); } },
                { "css", n => { Css = n.GetStringValue(); } },
                { "dashboard_title", n => { DashboardTitle = n.GetStringValue(); } },
                { "external_url", n => { ExternalUrl = n.GetStringValue(); } },
                { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
                { "json_metadata", n => { JsonMetadata = n.GetStringValue(); } },
                { "owners", n => { Owners = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                { "position_json", n => { PositionJson = n.GetStringValue(); } },
                { "published", n => { Published = n.GetBoolValue(); } },
                { "roles", n => { Roles = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("certification_details", CertificationDetails);
            writer.WriteStringValue("certified_by", CertifiedBy);
            writer.WriteStringValue("css", Css);
            writer.WriteStringValue("dashboard_title", DashboardTitle);
            writer.WriteStringValue("external_url", ExternalUrl);
            writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
            writer.WriteStringValue("json_metadata", JsonMetadata);
            writer.WriteCollectionOfPrimitiveValues<int?>("owners", Owners);
            writer.WriteStringValue("position_json", PositionJson);
            writer.WriteBoolValue("published", Published);
            writer.WriteCollectionOfPrimitiveValues<int?>("roles", Roles);
            writer.WriteStringValue("slug", Slug);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
