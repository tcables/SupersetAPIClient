
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Dataset.Item.Column.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\dataset\{pk}\column\{column_id}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithColumn_ItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/column/{column_id}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithColumn_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/dataset/{pk}/column/{column_id}", rawUrl)
    {
    }
    /// <summary>
    /// Delete a dataset column
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.Column.Item.WithColumn_DeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithColumn_401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Dataset.Item.Column.Item.WithColumn_DeleteResponse> DeleteAsWithColumn_DeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithColumn_401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithColumn_403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithColumn_404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithColumn_422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithColumn_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.Column.Item.WithColumn_DeleteResponse>(requestInfo, KApi.Dataset.Item.Column.Item.WithColumn_DeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dataset column
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.Column.Item.WithColumn_Response"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.WithColumn_401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_403Error">When receiving a 403 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.WithColumn_500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsWithColumn_DeleteResponseAsync instead.")]
    public async Task<KApi.Dataset.Item.Column.Item.WithColumn_Response> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.WithColumn_401Error.CreateFromDiscriminatorValue },
            { "403", KClient.Models.WithColumn_403Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.WithColumn_404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.WithColumn_422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.WithColumn_500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Dataset.Item.Column.Item.WithColumn_Response>(requestInfo, KApi.Dataset.Item.Column.Item.WithColumn_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Delete a dataset column
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
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Dataset.Item.Column.Item.WithColumn_ItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithColumn_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
