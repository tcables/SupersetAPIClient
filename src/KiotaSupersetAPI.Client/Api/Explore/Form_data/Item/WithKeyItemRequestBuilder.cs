
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Explore.Form_data.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\explore\form_data\{key}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Explore.Form_data.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/form_data/{key}{?tab_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Explore.Form_data.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/form_data/{key}{?tab_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a form_data
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<Explore.Form_data.Item.WithKeyDeleteResponse> DeleteAsWithKeyDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Form_data.Item.WithKeyDeleteResponse>(requestInfo, Explore.Form_data.Item.WithKeyDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a form_data
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithKeyDeleteResponseAsync instead.")]
    public async Task<Explore.Form_data.Item.WithKeyResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Form_data.Item.WithKeyResponse>(requestInfo, Explore.Form_data.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a form_data
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<Explore.Form_data.Item.WithKeyGetResponse> GetWithKeyGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Form_data.Item.WithKeyGetResponse>(requestInfo, Explore.Form_data.Item.WithKeyGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a form_data
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithKeyGetResponseAsync instead.")]
    public async Task<Explore.Form_data.Item.WithKeyResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Form_data.Item.WithKeyResponse>(requestInfo, Explore.Form_data.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an existing form_data
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyPutResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    public async Task<Explore.Form_data.Item.WithKeyPutResponse> PutAsWithKeyPutResponseAsync(Models.FormDataPutSchema body, Action<RequestConfiguration<Explore.Form_data.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Form_data.Item.WithKeyPutResponse>(requestInfo, Explore.Form_data.Item.WithKeyPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Update an existing form_data
    /// </summary>
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsWithKeyPutResponseAsync instead.")]
    public async Task<Explore.Form_data.Item.WithKeyResponse> PutAsync(Models.FormDataPutSchema body, Action<RequestConfiguration<Explore.Form_data.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPutRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Explore.Form_data.Item.WithKeyResponse>(requestInfo, Explore.Form_data.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a form_data
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
    /// Get a form_data
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
    /// Update an existing form_data
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Models.FormDataPutSchema body, Action<RequestConfiguration<Explore.Form_data.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Explore.Form_data.Item.WithKeyItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Form_data.Item.WithKeyItemRequestBuilder WithUrl(string rawUrl)
    {
        return new Form_data.Item.WithKeyItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
    /// <summary>
    /// Update an existing form_data
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderPutQueryParameters
    {
        [QueryParameter("tab_id")]
        public int? TabId { get; set; }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderPutRequestConfiguration : RequestConfiguration<Explore.Form_data.Item.WithKeyItemRequestBuilder.WithKeyItemRequestBuilderPutQueryParameters>
    {
    }
}
