
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public partial class DatabaseConnectionSchema : IAdditionalDataHolder, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData { get; set; }
    /// <summary>Allow CREATE TABLE AS option in SQL Lab</summary>
    public bool? AllowCtas { get; set; }
    /// <summary>Allow CREATE VIEW AS option in SQL Lab</summary>
    public bool? AllowCvas { get; set; }
    /// <summary>Allow users to run non-SELECT statements (UPDATE, DELETE, CREATE, ...) in SQL Lab</summary>
    public bool? AllowDml { get; set; }
    /// <summary>Allow to upload CSV file data into this databaseIf selected, please set the schemas allowed for csv upload in Extra.</summary>
    public bool? AllowFileUpload { get; set; }
    /// <summary>Operate the database in asynchronous mode, meaning that the queries are executed on remote workers as opposed to on the web server itself. This assumes that you have a Celery worker setup as well as a results backend. Refer to the installation docs for more information.</summary>
    public bool? AllowRunAsync { get; set; }
    /// <summary>SQLAlchemy engine to use</summary>
    public string Backend { get; set; }

    /// <summary>Duration (in seconds) of the caching timeout for charts of this database. A timeout of 0 indicates that the cache never expires. Note this defaults to the global timeout if undefined.</summary>
    public int? CacheTimeout { get; set; }
    /// <summary>Configuration_method is used on the frontend to inform the backend whether to explode parameters or to provide only a sqlalchemy_uri.</summary>
    public string ConfigurationMethod { get; set; }

    /// <summary>A database name to identify this connection.</summary>
    public string DatabaseName { get; set; }

    /// <summary>SQLAlchemy driver to use</summary>
    public string Driver { get; set; }

    /// <summary>The engine_information property</summary>
    public Models.DatabaseConnectionSchema_engine_information EngineInformation { get; set; }

    /// <summary>Expose this database to SQLLab</summary>
    public bool? ExposeInSqllab { get; set; }
    /// <summary>&lt;p&gt;JSON string containing extra configuration elements.&lt;br&gt;1. The &lt;code&gt;engine_params&lt;/code&gt; object gets unpacked into the &lt;a href=&quot;https://docs.sqlalchemy.org/en/latest/core/engines.html#sqlalchemy.create_engine&quot; rel=&quot;noopener noreferrer&quot;&gt;sqlalchemy.create_engine&lt;/a&gt; call, while the &lt;code&gt;metadata_params&lt;/code&gt; gets unpacked into the &lt;a href=&quot;https://docs.sqlalchemy.org/en/rel_1_0/core/metadata.html#sqlalchemy.schema.MetaData&quot; rel=&quot;noopener noreferrer&quot;&gt;sqlalchemy.MetaData&lt;/a&gt; call.&lt;br&gt;2. The &lt;code&gt;metadata_cache_timeout&lt;/code&gt; is a cache timeout setting in seconds for metadata fetch of this database. Specify it as &lt;strong&gt;&quot;metadata_cache_timeout&quot;: {&quot;schema_cache_timeout&quot;: 600, &quot;table_cache_timeout&quot;: 600}&lt;/strong&gt;. If unset, cache will not be enabled for the functionality. A timeout of 0 indicates that the cache never expires.&lt;br&gt;3. The &lt;code&gt;schemas_allowed_for_file_upload&lt;/code&gt; is a comma separated list of schemas that CSVs are allowed to upload to. Specify it as &lt;strong&gt;&quot;schemas_allowed_for_file_upload&quot;: [&quot;public&quot;, &quot;csv_upload&quot;]&lt;/strong&gt;. If database flavor does not support schema or any schema is allowed to be accessed, just leave the list empty&lt;br&gt;4. The &lt;code&gt;version&lt;/code&gt; field is a string specifying the this db&apos;s version. This should be used with Presto DBs so that the syntax is correct&lt;br&gt;5. The &lt;code&gt;allows_virtual_table_explore&lt;/code&gt; field is a boolean specifying whether or not the Explore button in SQL Lab results is shown.&lt;br&gt;6. The &lt;code&gt;disable_data_preview&lt;/code&gt; field is a boolean specifying whether or not data preview queries will be run when fetching table metadata in SQL Lab.&lt;/p&gt;</summary>
    public string Extra { get; set; }

    /// <summary>When allowing CREATE TABLE AS option in SQL Lab, this option forces the table to be created in this schema</summary>
    public string ForceCtasSchema { get; set; }

    /// <summary>Database ID (for updates)</summary>
    public int? Id { get; set; }
    /// <summary>If Presto, all the queries in SQL Lab are going to be executed as the currently logged on user who must have permission to run them.&lt;br/&gt;If Hive and hive.server2.enable.doAs is enabled, will run the queries as service account, but impersonate the currently logged on user via hive.server2.proxy.user property.</summary>
    public bool? ImpersonateUser { get; set; }
    /// <summary>The is_managed_externally property</summary>
    public bool? IsManagedExternally { get; set; }
    /// <summary>&lt;p&gt;JSON string containing additional connection configuration.&lt;br&gt;This is used to provide connection information for systems like Hive, Presto, and BigQuery, which do not conform to the username:password syntax normally used by SQLAlchemy.&lt;/p&gt;</summary>
    public string MaskedEncryptedExtra { get; set; }

    /// <summary>DB-specific parameters for configuration</summary>
    public Models.DatabaseConnectionSchema_parameters Parameters { get; set; }

    /// <summary>JSONSchema for configuring the database by parameters instead of SQLAlchemy URI</summary>
    public Models.DatabaseConnectionSchema_parameters_schema ParametersSchema { get; set; }

    /// <summary>&lt;p&gt;Optional CA_BUNDLE contents to validate HTTPS requests. Only available on certain database engines.&lt;/p&gt;</summary>
    public string ServerCert { get; set; }

    /// <summary>&lt;p&gt;Refer to the &lt;a href=&quot;https://docs.sqlalchemy.org/en/rel_1_2/core/engines.html#database-urls&quot; rel=&quot;noopener noreferrer&quot;&gt;SqlAlchemy docs&lt;/a&gt; for more information on how to structure your URI.&lt;/p&gt;</summary>
    public string SqlalchemyUri { get; set; }

    /// <summary>The ssh_tunnel property</summary>
    public Models.DatabaseSSHTunnel SshTunnel { get; set; }

    /// <summary>The uuid property</summary>
    public string Uuid { get; set; }

    /// <summary>
    /// Instantiates a new <see cref="Models.DatabaseConnectionSchema"/> and sets the default values.
    /// </summary>
    public DatabaseConnectionSchema()
    {
        AdditionalData = new Dictionary<string, object>();
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <returns>A <see cref="Models.DatabaseConnectionSchema"/></returns>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static Models.DatabaseConnectionSchema CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new Models.DatabaseConnectionSchema();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>>
        {
            { "allow_ctas", n => { AllowCtas = n.GetBoolValue(); } },
            { "allow_cvas", n => { AllowCvas = n.GetBoolValue(); } },
            { "allow_dml", n => { AllowDml = n.GetBoolValue(); } },
            { "allow_file_upload", n => { AllowFileUpload = n.GetBoolValue(); } },
            { "allow_run_async", n => { AllowRunAsync = n.GetBoolValue(); } },
            { "backend", n => { Backend = n.GetStringValue(); } },
            { "cache_timeout", n => { CacheTimeout = n.GetIntValue(); } },
            { "configuration_method", n => { ConfigurationMethod = n.GetStringValue(); } },
            { "database_name", n => { DatabaseName = n.GetStringValue(); } },
            { "driver", n => { Driver = n.GetStringValue(); } },
            { "engine_information", n => { EngineInformation = n.GetObjectValue<Models.DatabaseConnectionSchema_engine_information>(Models.DatabaseConnectionSchema_engine_information.CreateFromDiscriminatorValue); } },
            { "expose_in_sqllab", n => { ExposeInSqllab = n.GetBoolValue(); } },
            { "extra", n => { Extra = n.GetStringValue(); } },
            { "force_ctas_schema", n => { ForceCtasSchema = n.GetStringValue(); } },
            { "id", n => { Id = n.GetIntValue(); } },
            { "impersonate_user", n => { ImpersonateUser = n.GetBoolValue(); } },
            { "is_managed_externally", n => { IsManagedExternally = n.GetBoolValue(); } },
            { "masked_encrypted_extra", n => { MaskedEncryptedExtra = n.GetStringValue(); } },
            { "parameters", n => { Parameters = n.GetObjectValue<Models.DatabaseConnectionSchema_parameters>(Models.DatabaseConnectionSchema_parameters.CreateFromDiscriminatorValue); } },
            { "parameters_schema", n => { ParametersSchema = n.GetObjectValue<Models.DatabaseConnectionSchema_parameters_schema>(Models.DatabaseConnectionSchema_parameters_schema.CreateFromDiscriminatorValue); } },
            { "server_cert", n => { ServerCert = n.GetStringValue(); } },
            { "sqlalchemy_uri", n => { SqlalchemyUri = n.GetStringValue(); } },
            { "ssh_tunnel", n => { SshTunnel = n.GetObjectValue<Models.DatabaseSSHTunnel>(Models.DatabaseSSHTunnel.CreateFromDiscriminatorValue); } },
            { "uuid", n => { Uuid = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public virtual void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteBoolValue("allow_ctas", AllowCtas);
        writer.WriteBoolValue("allow_cvas", AllowCvas);
        writer.WriteBoolValue("allow_dml", AllowDml);
        writer.WriteBoolValue("allow_file_upload", AllowFileUpload);
        writer.WriteBoolValue("allow_run_async", AllowRunAsync);
        writer.WriteStringValue("backend", Backend);
        writer.WriteIntValue("cache_timeout", CacheTimeout);
        writer.WriteStringValue("configuration_method", ConfigurationMethod);
        writer.WriteStringValue("database_name", DatabaseName);
        writer.WriteStringValue("driver", Driver);
        writer.WriteObjectValue<Models.DatabaseConnectionSchema_engine_information>("engine_information", EngineInformation);
        writer.WriteBoolValue("expose_in_sqllab", ExposeInSqllab);
        writer.WriteStringValue("extra", Extra);
        writer.WriteStringValue("force_ctas_schema", ForceCtasSchema);
        writer.WriteIntValue("id", Id);
        writer.WriteBoolValue("impersonate_user", ImpersonateUser);
        writer.WriteBoolValue("is_managed_externally", IsManagedExternally);
        writer.WriteStringValue("masked_encrypted_extra", MaskedEncryptedExtra);
        writer.WriteObjectValue<Models.DatabaseConnectionSchema_parameters>("parameters", Parameters);
        writer.WriteObjectValue<Models.DatabaseConnectionSchema_parameters_schema>("parameters_schema", ParametersSchema);
        writer.WriteStringValue("server_cert", ServerCert);
        writer.WriteStringValue("sqlalchemy_uri", SqlalchemyUri);
        writer.WriteObjectValue<Models.DatabaseSSHTunnel>("ssh_tunnel", SshTunnel);
        writer.WriteStringValue("uuid", Uuid);
        writer.WriteAdditionalData(AdditionalData);
    }
}
