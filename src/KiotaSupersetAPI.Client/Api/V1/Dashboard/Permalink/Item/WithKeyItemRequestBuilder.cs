
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dashboard.Permalink.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dashboard\permalink\{key}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithKeyItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dashboard.Permalink.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/permalink/{key}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dashboard.Permalink.Item.WithKeyItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dashboard/permalink/{key}", rawUrl)
    {
    }
    /// <summary>
    /// Get dashboard&apos;s permanent link state
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.Permalink.Item.WithKeyGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithKey500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dashboard.Permalink.Item.WithKeyGetResponse?> GetAsWithKeyGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dashboard.Permalink.Item.WithKeyGetResponse> GetAsWithKeyGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.Permalink.Item.WithKeyGetResponse>(requestInfo, KApi.Dashboard.Permalink.Item.WithKeyGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get dashboard&apos;s permanent link state
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.Permalink.Item.WithKeyResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithKey400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.WithKey401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithKey404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithKey422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithKey500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsWithKeyGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dashboard.Permalink.Item.WithKeyResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dashboard.Permalink.Item.WithKeyResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.WithKey400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.WithKey401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithKey404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithKey422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithKey500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dashboard.Permalink.Item.WithKeyResponse>(requestInfo, KApi.Dashboard.Permalink.Item.WithKeyResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get dashboard&apos;s permanent link state
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
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Dashboard.Permalink.Item.WithKeyItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dashboard.Permalink.Item.WithKeyItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dashboard.Permalink.Item.WithKeyItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithKeyItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
