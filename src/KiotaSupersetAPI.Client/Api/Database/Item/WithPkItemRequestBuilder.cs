
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The connection property</summary>
    public Database.Item.Connection.ConnectionRequestBuilder Connection
    {
        get => new Database.Item.Connection.ConnectionRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The function_names property</summary>
    public Database.Item.Function_names.Function_namesRequestBuilder Function_names
    {
        get => new Database.Item.Function_names.Function_namesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related_objects property</summary>
    public Database.Item.Related_objects.Related_objectsRequestBuilder Related_objects
    {
        get => new Database.Item.Related_objects.Related_objectsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The schemas property</summary>
    public Database.Item.Schemas.SchemasRequestBuilder Schemas
    {
        get => new Database.Item.Schemas.SchemasRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The schemas_access_for_file_upload property</summary>
    public Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder Schemas_access_for_file_upload
    {
        get => new Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The select_star property</summary>
    public Database.Item.Select_star.Select_starRequestBuilder Select_star
    {
        get => new Database.Item.Select_star.Select_starRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The ssh_tunnel property</summary>
    public Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder Ssh_tunnel
    {
        get => new Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The table property</summary>
    public Database.Item.Table.TableRequestBuilder Table
    {
        get => new Database.Item.Table.TableRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The table_extra property</summary>
    public Database.Item.Table_extra.Table_extraRequestBuilder Table_extra
    {
        get => new Database.Item.Table_extra.Table_extraRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The tables property</summary>
    public Database.Item.Tables.TablesRequestBuilder Tables
    {
        get => new Database.Item.Tables.TablesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The validate_sql property</summary>
    public Database.Item.Validate_sql.Validate_sqlRequestBuilder Validate_sql
    {
        get => new Database.Item.Validate_sql.Validate_sqlRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a database
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Database.Item.WithPkDeleteResponse> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.WithPkDeleteResponse>(requestInfo, Database.Item.WithPkDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a database
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithPkDeleteResponseAsync instead.")]
    public async Task<Database.Item.WithPkResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.WithPkResponse>(requestInfo, Database.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a database
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Database.Item.WithPkGetResponse> GetWithPkGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.WithPkGetResponse>(requestInfo, Database.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a database
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
    public async Task<Database.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.WithPkResponse>(requestInfo, Database.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Change a database
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Database.Item.WithPkPutResponse> PutAsWithPkPutResponseAsync(Models.DatabaseRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.WithPkPutResponse>(requestInfo, Database.Item.WithPkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Change a database
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithPkPutResponseAsync instead.")]
    public async Task<Database.Item.WithPkResponse> PutAsync(Models.DatabaseRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.WithPkResponse>(requestInfo, Database.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a database
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Get a database
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Change a database
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.DatabaseRestAPI.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Database.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Database.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Database.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
