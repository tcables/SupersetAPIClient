
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Available;

[GeneratedCode("Kiota", "1.16.0")]
#pragma warning disable CS1591
public partial class Available : IAdditionalDataHolder, IParsable
#pragma warning restore CS1591
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Installed drivers for the engine</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? AvailableDrivers { get; set; }
#nullable restore
#else
    public List<string> AvailableDrivers { get; set; }
#endif
    /// <summary>Default driver for the engine</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? DefaultDriver { get; set; }
#nullable restore
#else
    public string DefaultDriver { get; set; }
#endif
    /// <summary>Name of the SQLAlchemy engine</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Engine { get; set; }
#nullable restore
#else
    public string Engine { get; set; }
#endif
    /// <summary>Dict with public properties form the DB Engine</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.Database.Available.Available_engine_information? EngineInformation { get; set; }
#nullable restore
#else
    public KApi.Database.Available.Available_engine_information EngineInformation { get; set; }
#endif
    /// <summary>Name of the database</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Name { get; set; }
#nullable restore
#else
    public string Name { get; set; }
#endif
    /// <summary>JSON schema defining the needed parameters</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public KApi.Database.Available.Available_parameters? Parameters { get; set; }
#nullable restore
#else
    public KApi.Database.Available.Available_parameters Parameters { get; set; }
#endif
    /// <summary>Is the database preferred?</summary>
    public bool? Preferred { get; set; }
    /// <summary>Example placeholder for the SQLAlchemy URI</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? SqlalchemyUriPlaceholder { get; set; }
#nullable restore
#else
    public string SqlalchemyUriPlaceholder { get; set; }
#endif
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Available.Available"/> and sets the default values.
    /// </summary>
    public Available()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Available.Available"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KApi.Database.Available.Available CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KApi.Database.Available.Available();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "available_drivers", n => { AvailableDrivers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            { "default_driver", n => { DefaultDriver = n.GetStringValue(); } },
            { "engine", n => { Engine = n.GetStringValue(); } },
            { "engine_information", n => { EngineInformation = n.GetObjectValue<KApi.Database.Available.Available_engine_information>(KApi.Database.Available.Available_engine_information.CreateFromDiscriminatorValue); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "parameters", n => { Parameters = n.GetObjectValue<KApi.Database.Available.Available_parameters>(KApi.Database.Available.Available_parameters.CreateFromDiscriminatorValue); } },
            { "preferred", n => { Preferred = n.GetBoolValue(); } },
            { "sqlalchemy_uri_placeholder", n => { SqlalchemyUriPlaceholder = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteCollectionOfPrimitiveValues<string>("available_drivers", AvailableDrivers);
        writer.WriteStringValue("default_driver", DefaultDriver);
        writer.WriteStringValue("engine", Engine);
        writer.WriteObjectValue<KApi.Database.Available.Available_engine_information>("engine_information", EngineInformation);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<KApi.Database.Available.Available_parameters>("parameters", Parameters);
        writer.WriteBoolValue("preferred", Preferred);
        writer.WriteStringValue("sqlalchemy_uri_placeholder", SqlalchemyUriPlaceholder);
        writer.WriteAdditionalData(AdditionalData);
    }
}
