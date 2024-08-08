
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

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Duplicate;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\duplicate
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DuplicateRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Duplicate.DuplicateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DuplicateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/duplicate", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Duplicate.DuplicateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DuplicateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/duplicate", rawUrl)
    {
    }
    /// <summary>
    /// Duplicate a dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Duplicate.DuplicatePostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Duplicate400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Duplicate401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Duplicate403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Duplicate404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Duplicate422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Duplicate500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Duplicate.DuplicatePostResponse?> PostAsDuplicatePostResponseAsync(KClient.Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Duplicate.DuplicatePostResponse> PostAsDuplicatePostResponseAsync(KClient.Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Duplicate400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Duplicate401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Duplicate403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Duplicate404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Duplicate422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Duplicate500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Duplicate.DuplicatePostResponse>(requestInfo, KApi.Dataset.Duplicate.DuplicatePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Duplicate a dataset
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Duplicate.DuplicateResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Duplicate400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Duplicate401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Duplicate403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Duplicate404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Duplicate422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Duplicate500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsDuplicatePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Dataset.Duplicate.DuplicateResponse?> PostAsync(KClient.Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Dataset.Duplicate.DuplicateResponse> PostAsync(KClient.Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Duplicate400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Duplicate401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Duplicate403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Duplicate404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Duplicate422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Duplicate500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Duplicate.DuplicateResponse>(requestInfo, KApi.Dataset.Duplicate.DuplicateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Duplicate a dataset
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPostRequestInformation(KClient.Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPostRequestInformation(KClient.Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Duplicate.DuplicateRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dataset.Duplicate.DuplicateRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dataset.Duplicate.DuplicateRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DuplicateRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
