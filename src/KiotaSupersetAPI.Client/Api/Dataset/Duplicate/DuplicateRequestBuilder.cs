
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Dataset.Duplicate;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\duplicate
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class DuplicateRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Duplicate.DuplicateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DuplicateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/duplicate", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Duplicate.DuplicateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public DuplicateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/duplicate", rawUrl)
    {
    }
    /// <summary>
    /// Duplicate a dataset
    /// </summary>
    /// <returns>A <see cref="Dataset.Duplicate.DuplicatePostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Duplicate400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Duplicate401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Duplicate403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Duplicate404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Duplicate422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Duplicate500Error">When receiving a 500 status code</exception>
    public async Task<Dataset.Duplicate.DuplicatePostResponse> PostAsDuplicatePostResponseAsync(Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Duplicate400Error.CreateFromDiscriminatorValue },
            { "401", Models.Duplicate401Error.CreateFromDiscriminatorValue },
            { "403", Models.Duplicate403Error.CreateFromDiscriminatorValue },
            { "404", Models.Duplicate404Error.CreateFromDiscriminatorValue },
            { "422", Models.Duplicate422Error.CreateFromDiscriminatorValue },
            { "500", Models.Duplicate500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.Duplicate.DuplicatePostResponse>(requestInfo, Dataset.Duplicate.DuplicatePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Duplicate a dataset
    /// </summary>
    /// <returns>A <see cref="Dataset.Duplicate.DuplicateResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Duplicate400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Duplicate401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Duplicate403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Duplicate404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Duplicate422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Duplicate500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsDuplicatePostResponseAsync instead.")]
    public async Task<Dataset.Duplicate.DuplicateResponse> PostAsync(Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Duplicate400Error.CreateFromDiscriminatorValue },
            { "401", Models.Duplicate401Error.CreateFromDiscriminatorValue },
            { "403", Models.Duplicate403Error.CreateFromDiscriminatorValue },
            { "404", Models.Duplicate404Error.CreateFromDiscriminatorValue },
            { "422", Models.Duplicate422Error.CreateFromDiscriminatorValue },
            { "500", Models.Duplicate500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.Duplicate.DuplicateResponse>(requestInfo, Dataset.Duplicate.DuplicateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Duplicate a dataset
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.DatasetDuplicateSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

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
    /// <returns>A <see cref="Dataset.Duplicate.DuplicateRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dataset.Duplicate.DuplicateRequestBuilder WithUrl(string rawUrl)
    {
        return new Dataset.Duplicate.DuplicateRequestBuilder(rawUrl, RequestAdapter);
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
