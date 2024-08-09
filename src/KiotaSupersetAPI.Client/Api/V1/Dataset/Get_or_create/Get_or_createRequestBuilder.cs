
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Dataset.Get_or_create;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\get_or_create
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Get_or_createRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Get_or_create.Get_or_createRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Get_or_createRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/get_or_create", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Get_or_create.Get_or_createRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Get_or_createRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/get_or_create", rawUrl)
    {
    }
    /// <summary>
    /// Retrieve a table by name, or create it if it does not exist
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Get_or_create.Get_or_createPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Get_or_create400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Get_or_create401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Get_or_create422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Get_or_create500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dataset.Get_or_create.Get_or_createPostResponse> PostAsGet_or_createPostResponseAsync(KClient.Models.GetOrCreateDatasetSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Get_or_create400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Get_or_create401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Get_or_create422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Get_or_create500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Get_or_create.Get_or_createPostResponse>(requestInfo, KApi.Dataset.Get_or_create.Get_or_createPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Retrieve a table by name, or create it if it does not exist
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Get_or_create.Get_or_createResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Get_or_create400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Get_or_create401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Get_or_create422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Get_or_create500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsGet_or_createPostResponseAsync instead.")]
    public async Task<KApi.Dataset.Get_or_create.Get_or_createResponse> PostAsync(KClient.Models.GetOrCreateDatasetSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Get_or_create400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Get_or_create401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Get_or_create422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Get_or_create500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Get_or_create.Get_or_createResponse>(requestInfo, KApi.Dataset.Get_or_create.Get_or_createResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Retrieve a table by name, or create it if it does not exist
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KClient.Models.GetOrCreateDatasetSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Dataset.Get_or_create.Get_or_createRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dataset.Get_or_create.Get_or_createRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dataset.Get_or_create.Get_or_createRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Get_or_createRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
