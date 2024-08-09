
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Available;

[GeneratedCode("Kiota", "1.16.0")]
public partial class Available : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Installed drivers for the engine</summary>
    public List<string> AvailableDrivers { get; set; }

    /// <summary>Default driver for the engine</summary>
    public string DefaultDriver { get; set; }

    /// <summary>Name of the SQLAlchemy engine</summary>
    public string Engine { get; set; }

    /// <summary>Dict with public properties form the DB Engine</summary>
    public Database.Available.Available_engine_information EngineInformation { get; set; }

    /// <summary>Name of the database</summary>
    public string Name { get; set; }

    /// <summary>JSON schema defining the needed parameters</summary>
    public Database.Available.Available_parameters Parameters { get; set; }

    /// <summary>Is the database preferred?</summary>
    public bool? Preferred { get; set; }
    /// <summary>Example placeholder for the SQLAlchemy URI</summary>
    public string SqlalchemyUriPlaceholder { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Database.Available.Available"/> and sets the default values.
    /// </summary>
    public Available()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Database.Available.Available"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Database.Available.Available CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Database.Available.Available();
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
            { "engine_information", n => { EngineInformation = n.GetObjectValue<Database.Available.Available_engine_information>(Database.Available.Available_engine_information.CreateFromDiscriminatorValue); } },
            { "name", n => { Name = n.GetStringValue(); } },
            { "parameters", n => { Parameters = n.GetObjectValue<Database.Available.Available_parameters>(Database.Available.Available_parameters.CreateFromDiscriminatorValue); } },
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
        writer.WriteObjectValue<Database.Available.Available_engine_information>("engine_information", EngineInformation);
        writer.WriteStringValue("name", Name);
        writer.WriteObjectValue<Database.Available.Available_parameters>("parameters", Parameters);
        writer.WriteBoolValue("preferred", Preferred);
        writer.WriteStringValue("sqlalchemy_uri_placeholder", SqlalchemyUriPlaceholder);
        writer.WriteAdditionalData(AdditionalData);
    }
}
