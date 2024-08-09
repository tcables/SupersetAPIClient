
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Dataset.Item.Refresh;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\{pk}\refresh
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class RefreshRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Item.Refresh.RefreshRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RefreshRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/refresh", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Dataset.Item.Refresh.RefreshRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public RefreshRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/refresh", rawUrl)
    {
    }
    /// <summary>
    /// Refresh and update columns of a dataset
    /// </summary>
    /// <returns>A <see cref="Dataset.Item.Refresh.RefreshPutResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Refresh401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Refresh403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Refresh404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Refresh422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Refresh500Error">When receiving a 500 status code</exception>
    public async Task<Dataset.Item.Refresh.RefreshPutResponse> PutAsRefreshPutResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToPutRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Refresh401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Refresh403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Refresh404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Refresh422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Refresh500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.Item.Refresh.RefreshPutResponse>(requestInfo, Dataset.Item.Refresh.RefreshPutResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Refresh and update columns of a dataset
    /// </summary>
    /// <returns>A <see cref="Dataset.Item.Refresh.RefreshResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Refresh401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Refresh403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.Refresh404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Refresh422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Refresh500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PutAsRefreshPutResponseAsync instead.")]
    public async Task<Dataset.Item.Refresh.RefreshResponse> PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToPutRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Refresh401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.Refresh403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Refresh404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Refresh422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Refresh500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Dataset.Item.Refresh.RefreshResponse>(requestInfo, Dataset.Item.Refresh.RefreshResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Refresh and update columns of a dataset
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Dataset.Item.Refresh.RefreshRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Dataset.Item.Refresh.RefreshRequestBuilder WithUrl(string rawUrl)
    {
        return new Dataset.Item.Refresh.RefreshRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class RefreshRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
