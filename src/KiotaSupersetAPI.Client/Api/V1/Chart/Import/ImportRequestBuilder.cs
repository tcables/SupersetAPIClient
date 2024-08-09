
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.API;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Chart.Import;

/// <summary>
/// Builds and executes requests for operations under \api\v1\chart\import
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ImportRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Import.ImportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ImportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/import", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Chart.Import.ImportRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ImportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/chart/import", rawUrl)
    {
    }
    /// <summary>
    /// Import chart(s) with associated datasets and databases
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Import.ImportPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Import400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Import401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Import422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Import500Error">When receiving a 500 status code</exception>
    public async Task<KApi.Chart.Import.ImportPostResponse> PostAsImportPostResponseAsync(KApi.Chart.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Import400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Import401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Import422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Import500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.Import.ImportPostResponse>(requestInfo, KApi.Chart.Import.ImportPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Import chart(s) with associated datasets and databases
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Import.ImportResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Import400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Import401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Import422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Import500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsImportPostResponseAsync instead.")]
    public async Task<KApi.Chart.Import.ImportResponse> PostAsync(KApi.Chart.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Import400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Import401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Import422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Import500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Chart.Import.ImportResponse>(requestInfo, KApi.Chart.Import.ImportResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Import chart(s) with associated datasets and databases
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(KApi.Chart.Import.ImportPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Chart.Import.ImportRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Chart.Import.ImportRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Chart.Import.ImportRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ImportRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
