
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Rowlevelsecurity.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\rowlevelsecurity\{pk}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithPkItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Rowlevelsecurity.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/rowlevelsecurity/{pk}{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Rowlevelsecurity.Item.WithPkItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithPkItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/rowlevelsecurity/{pk}{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete an RLS
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Rowlevelsecurity.Item.WithPkDeleteResponse> DeleteAsWithPkDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Rowlevelsecurity.Item.WithPkDeleteResponse>(requestInfo, Rowlevelsecurity.Item.WithPkDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete an RLS
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithPkDeleteResponseAsync instead.")]
    public async Task<Rowlevelsecurity.Item.WithPkResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Rowlevelsecurity.Item.WithPkResponse>(requestInfo, Rowlevelsecurity.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Rowlevelsecurity.Item.WithPkGetResponse> GetWithPkGetResponseAsync(Action<RequestConfiguration<Rowlevelsecurity.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Rowlevelsecurity.Item.WithPkGetResponse>(requestInfo, Rowlevelsecurity.Item.WithPkGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithPkGetResponseAsync instead.")]
    public async Task<Rowlevelsecurity.Item.WithPkResponse> GetAsync(Action<RequestConfiguration<Rowlevelsecurity.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithPk400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithPk401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithPk404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithPk422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithPk500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Rowlevelsecurity.Item.WithPkResponse>(requestInfo, Rowlevelsecurity.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an RLS rule
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithPk400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithPk401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithPk403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.WithPk404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithPk422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithPk500Error">When receiving a 500 status code</exception>
    public async Task<Rowlevelsecurity.Item.WithPkPutResponse> PutAsWithPkPutResponseAsync(Models.RLSRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
        return await RequestAdapter.SendAsync<Rowlevelsecurity.Item.WithPkPutResponse>(requestInfo, Rowlevelsecurity.Item.WithPkPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an RLS rule
    /// </summary>
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkResponse"/></returns>
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
    public async Task<Rowlevelsecurity.Item.WithPkResponse> PutAsync(Models.RLSRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
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
        return await RequestAdapter.SendAsync<Rowlevelsecurity.Item.WithPkResponse>(requestInfo, Rowlevelsecurity.Item.WithPkResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete an RLS
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
    /// Get an item model
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Rowlevelsecurity.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Update an RLS rule
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.RLSRestApi.Put body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Rowlevelsecurity.Item.WithPkItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Rowlevelsecurity.Item.WithPkItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Rowlevelsecurity.Item.WithPkItemRequestBuilder(rawUrl, RequestAdapter);
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
    /// Get an item model
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithPkItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Rowlevelsecurity.Item.WithPkItemRequestBuilder.WithPkItemRequestBuilderGetQueryParameters>
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
