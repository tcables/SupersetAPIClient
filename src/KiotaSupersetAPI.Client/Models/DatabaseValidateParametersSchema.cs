
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatabaseValidateParametersSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Gsheets specific column for managing label to sheet urls</summary>
    public KClient.Models.DatabaseValidateParametersSchema_catalog Catalog { get; set; }

    /// <summary>Configuration_method is used on the frontend to inform the backend whether to explode parameters or to provide only a sqlalchemy_uri.</summary>
    public KClient.Models.DatabaseValidateParametersSchema_configuration_method? ConfigurationMethod { get; set; }
    /// <summary>A database name to identify this connection.</summary>
    public string DatabaseName { get; set; }

    /// <summary>SQLAlchemy driver to use</summary>
    public string Driver { get; set; }

    /// <summary>SQLAlchemy engine to use</summary>
    public string Engine { get; set; }

    /// <summary>&lt;p&gt;JSON string containing extra configuration elements.&lt;br&gt;1. The &lt;code&gt;engine_params&lt;/code&gt; object gets unpacked into the &lt;a href=&quot;https://docs.sqlalchemy.org/en/latest/core/engines.html#sqlalchemy.create_engine&quot; rel=&quot;noopener noreferrer&quot;&gt;sqlalchemy.create_engine&lt;/a&gt; call, while the &lt;code&gt;metadata_params&lt;/code&gt; gets unpacked into the &lt;a href=&quot;https://docs.sqlalchemy.org/en/rel_1_0/core/metadata.html#sqlalchemy.schema.MetaData&quot; rel=&quot;noopener noreferrer&quot;&gt;sqlalchemy.MetaData&lt;/a&gt; call.&lt;br&gt;2. The &lt;code&gt;metadata_cache_timeout&lt;/code&gt; is a cache timeout setting in seconds for metadata fetch of this database. Specify it as &lt;strong&gt;&quot;metadata_cache_timeout&quot;: {&quot;schema_cache_timeout&quot;: 600, &quot;table_cache_timeout&quot;: 600}&lt;/strong&gt;. If unset, cache will not be enabled for the functionality. A timeout of 0 indicates that the cache never expires.&lt;br&gt;3. The &lt;code&gt;schemas_allowed_for_file_upload&lt;/code&gt; is a comma separated list of schemas that CSVs are allowed to upload to. Specify it as &lt;strong&gt;&quot;schemas_allowed_for_file_upload&quot;: [&quot;public&quot;, &quot;csv_upload&quot;]&lt;/strong&gt;. If database flavor does not support schema or any schema is allowed to be accessed, just leave the list empty&lt;br&gt;4. The &lt;code&gt;version&lt;/code&gt; field is a string specifying the this db&apos;s version. This should be used with Presto DBs so that the syntax is correct&lt;br&gt;5. The &lt;code&gt;allows_virtual_table_explore&lt;/code&gt; field is a boolean specifying whether or not the Explore button in SQL Lab results is shown.&lt;br&gt;6. The &lt;code&gt;disable_data_preview&lt;/code&gt; field is a boolean specifying whether or not data preview queries will be run when fetching table metadata in SQL Lab.&lt;/p&gt;</summary>
    public string Extra { get; set; }

    /// <summary>Database ID (for updates)</summary>
    public int? Id { get; set; }
    /// <summary>If Presto, all the queries in SQL Lab are going to be executed as the currently logged on user who must have permission to run them.&lt;br/&gt;If Hive and hive.server2.enable.doAs is enabled, will run the queries as service account, but impersonate the currently logged on user via hive.server2.proxy.user property.</summary>
    public bool? ImpersonateUser { get; set; }
    /// <summary>&lt;p&gt;JSON string containing additional connection configuration.&lt;br&gt;This is used to provide connection information for systems like Hive, Presto, and BigQuery, which do not conform to the username:password syntax normally used by SQLAlchemy.&lt;/p&gt;</summary>
    public string MaskedEncryptedExtra { get; set; }

    /// <summary>DB-specific parameters for configuration</summary>
    public KClient.Models.DatabaseValidateParametersSchema_parameters Parameters { get; set; }

    /// <summary>&lt;p&gt;Optional CA_BUNDLE contents to validate HTTPS requests. Only available on certain database engines.&lt;/p&gt;</summary>
    public string ServerCert { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="KClient.Models.DatabaseValidateParametersSchema"/> and sets the default values.
    /// </summary>
    public DatabaseValidateParametersSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseValidateParametersSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static KClient.Models.DatabaseValidateParametersSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new KClient.Models.DatabaseValidateParametersSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "catalog", n => { Catalog = n.GetObjectValue<KClient.Models.DatabaseValidateParametersSchema_catalog>(KClient.Models.DatabaseValidateParametersSchema_catalog.CreateFromDiscriminatorValue); } },
            { "configuration_method", n => { ConfigurationMethod = n.GetEnumValue<KClient.Models.DatabaseValidateParametersSchema_configuration_method>(); } },
            { "database_name", n => { DatabaseName = n.GetStringValue(); } },
            { "driver", n => { Driver = n.GetStringValue(); } },
            { "engine", n => { Engine = n.GetStringValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "impersonate_user", n => { ImpersonateUser = n.GetBoolValue(); } },
            { "masked_encrypted_extra", n => { MaskedEncryptedExtra = n.GetStringValue(); } },
            { "parameters", n => { Parameters = n.GetObjectValue<KClient.Models.DatabaseValidateParametersSchema_parameters>(KClient.Models.DatabaseValidateParametersSchema_parameters.CreateFromDiscriminatorValue); } },
            { "server_cert", n => { ServerCert = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteObjectValue<KClient.Models.DatabaseValidateParametersSchema_catalog>("catalog", Catalog);
        writer.WriteEnumValue<KClient.Models.DatabaseValidateParametersSchema_configuration_method>("configuration_method", ConfigurationMethod);
        writer.WriteStringValue("database_name", DatabaseName);
        writer.WriteStringValue("driver", Driver);
        writer.WriteStringValue("engine", Engine);
        writer.WriteStringValue("extra", Extra);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("impersonate_user", ImpersonateUser);
        writer.WriteStringValue("masked_encrypted_extra", MaskedEncryptedExtra);
        writer.WriteObjectValue<KClient.Models.DatabaseValidateParametersSchema_parameters>("parameters", Parameters);
        writer.WriteStringValue("server_cert", ServerCert);
        writer.WriteAdditionalData(AdditionalData);
    }
}
