
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Connection;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Function_names;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Related_objects;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Schemas;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Schemas_access_for_file_upload;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Select_star;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Ssh_tunnel;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Table;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Table_extra;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Tables;
using KiotaSupersetAPI.Client.Api.V1.Database.Item.Validate_sql;
using KiotaSupersetAPI.Client.Models;
using KiotaSupersetAPI.Client.Models.DatabaseRestApi;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>The connection property</summary>
    public KApi.Database.Item.Connection.ConnectionRequestBuilder Connection
    {
        get => new KApi.Database.Item.Connection.ConnectionRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The function_names property</summary>
    public KApi.Database.Item.Function_names.Function_namesRequestBuilder Function_names
    {
        get => new KApi.Database.Item.Function_names.Function_namesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related_objects property</summary>
    public KApi.Database.Item.Related_objects.Related_objectsRequestBuilder Related_objects
    {
        get => new KApi.Database.Item.Related_objects.Related_objectsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The schemas property</summary>
    public KApi.Database.Item.Schemas.SchemasRequestBuilder Schemas
    {
        get => new KApi.Database.Item.Schemas.SchemasRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The schemas_access_for_file_upload property</summary>
    public KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder Schemas_access_for_file_upload
    {
        get => new KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The select_star property</summary>
    public KApi.Database.Item.Select_star.Select_starRequestBuilder Select_star
    {
        get => new KApi.Database.Item.Select_star.Select_starRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The ssh_tunnel property</summary>
    public KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder Ssh_tunnel
    {
        get => new KApi.Database.Item.Ssh_tunnel.Ssh_tunnelRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The table property</summary>
    public KApi.Database.Item.Table.TableRequestBuilder Table
    {
        get => new KApi.Database.Item.Table.TableRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The table_extra property</summary>
    public KApi.Database.Item.Table_extra.Table_extraRequestBuilder Table_extra
    {
        get => new KApi.Database.Item.Table_extra.Table_extraRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The tables property</summary>
    public KApi.Database.Item.Tables.TablesRequestBuilder Tables
    {
        get => new KApi.Database.Item.Tables.TablesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The validate_sql property</summary>
    public KApi.Database.Item.Validate_sql.Validate_sqlRequestBuilder Validate_sql
    {
        get => new KApi.Database.Item.Validate_sql.Validate_sqlRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.WithPkDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Database.Item.WithPkDeleteResponse?> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Database.Item.WithPkDeleteResponse> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.WithPkDeleteResponse>(requestInfo, KApi.Database.Item.WithPkDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithPkDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Database.Item.WithPkResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Database.Item.WithPkResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.WithPkResponse>(requestInfo, KApi.Database.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Database.Item.WithPkGetResponse?> GetAsWithPkGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Database.Item.WithPkGetResponse> GetAsWithPkGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.WithPkGetResponse>(requestInfo, KApi.Database.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Database.Item.WithPkResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Database.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.WithPkResponse>(requestInfo, KApi.Database.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Change a database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.WithPkPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Database.Item.WithPkPutResponse?> PutAsWithPkPutResponseAsync(KClient.Models.DatabaseRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Database.Item.WithPkPutResponse> PutAsWithPkPutResponseAsync(KClient.Models.DatabaseRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.WithPkPutResponse>(requestInfo, KApi.Database.Item.WithPkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Change a database
    /// </summary>
    /// <returns>A <see cref="KApi.Database.Item.WithPkResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithPkPutResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Database.Item.WithPkResponse?> PutAsync(KClient.Models.DatabaseRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Database.Item.WithPkResponse> PutAsync(KClient.Models.DatabaseRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithPk403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Database.Item.WithPkResponse>(requestInfo, KApi.Database.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a database
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPutRequestInformation(KClient.Models.DatabaseRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPutRequestInformation(KClient.Models.DatabaseRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
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
    /// <returns>A <see cref="KApi.Database.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Database.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Database.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
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
