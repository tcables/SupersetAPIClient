
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Sqllab.Estimate;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab\estimate
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class EstimateRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Estimate.EstimateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public EstimateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/estimate", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Estimate.EstimateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public EstimateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/estimate", rawUrl)
    {
    }
    /// <summary>
    /// Estimate the SQL query execution cost
    /// </summary>
    /// <returns>A <see cref="Sqllab.Estimate.EstimatePostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Estimate400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Estimate401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Estimate403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Estimate500Error">When receiving a 500 status code</exception>
    public async Task<Sqllab.Estimate.EstimatePostResponse> PostAsEstimatePostResponseAsync(KClient.Models.EstimateQueryCostSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Estimate400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Estimate401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Estimate403Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Estimate500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Sqllab.Estimate.EstimatePostResponse>(requestInfo, Sqllab.Estimate.EstimatePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Estimate the SQL query execution cost
    /// </summary>
    /// <returns>A <see cref="Sqllab.Estimate.EstimateResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Estimate400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Estimate401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Estimate403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Estimate500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsEstimatePostResponseAsync instead.")]
    public async Task<Sqllab.Estimate.EstimateResponse> PostAsync(KClient.Models.EstimateQueryCostSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Estimate400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Estimate401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Estimate403Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Estimate500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Sqllab.Estimate.EstimateResponse>(requestInfo, Sqllab.Estimate.EstimateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Estimate the SQL query execution cost
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.EstimateQueryCostSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Sqllab.Estimate.EstimateRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Sqllab.Estimate.EstimateRequestBuilder WithUrl(string rawUrl)
    {
        return new Sqllab.Estimate.EstimateRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class EstimateRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
