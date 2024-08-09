
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Tag.Bulk_create;

/// <summary>
/// Builds and executes requests for operations under \api\v1\tag\bulk_create
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Bulk_createRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Tag.Bulk_create.Bulk_createRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Bulk_createRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/bulk_create", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Tag.Bulk_create.Bulk_createRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Bulk_createRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/tag/bulk_create", rawUrl)
    {
    }
    /// <summary>
    /// Get all objects associated with a tag
    /// </summary>
    /// <returns>A <see cref="Tag.Bulk_create.Bulk_createPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Bulk_create400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Bulk_create401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Bulk_create404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Bulk_create500Error">When receiving a 500 status code</exception>
    public async Task<Tag.Bulk_create.Bulk_createPostResponse> PostAsBulk_createPostResponseAsync(Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Bulk_create400Error.CreateFromDiscriminatorValue },
            { "401", Models.Bulk_create401Error.CreateFromDiscriminatorValue },
            { "404", Models.Bulk_create404Error.CreateFromDiscriminatorValue },
            { "500", Models.Bulk_create500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Bulk_create.Bulk_createPostResponse>(requestInfo, Tag.Bulk_create.Bulk_createPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all objects associated with a tag
    /// </summary>
    /// <returns>A <see cref="Tag.Bulk_create.Bulk_createResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Bulk_create400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Bulk_create401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Bulk_create404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Bulk_create500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsBulk_createPostResponseAsync instead.")]
    public async Task<Tag.Bulk_create.Bulk_createResponse> PostAsync(Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Bulk_create400Error.CreateFromDiscriminatorValue },
            { "401", Models.Bulk_create401Error.CreateFromDiscriminatorValue },
            { "404", Models.Bulk_create404Error.CreateFromDiscriminatorValue },
            { "500", Models.Bulk_create500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Tag.Bulk_create.Bulk_createResponse>(requestInfo, Tag.Bulk_create.Bulk_createResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all objects associated with a tag
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Tag.Bulk_create.Bulk_createPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Tag.Bulk_create.Bulk_createRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Tag.Bulk_create.Bulk_createRequestBuilder WithUrl(string rawUrl)
    {
        return new Tag.Bulk_create.Bulk_createRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Bulk_createRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
