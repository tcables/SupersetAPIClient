
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Explore.Form_data;

/// <summary>
/// Builds and executes requests for operations under \api\v1\explore\form_data
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Form_dataRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.explore.form_data.item collection</summary>
    /// <param name="position">The form_data key.</param>
    /// <returns>A <see cref="KApi.Explore.Form_data.Item.WithKeyItemRequestBuilder"/></returns>
    public KApi.Explore.Form_data.Item.WithKeyItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("key", position);
            return new KApi.Explore.Form_data.Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Explore.Form_data.Form_dataRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Form_dataRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/form_data{?tab_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Explore.Form_data.Form_dataRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Form_dataRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore/form_data{?tab_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Create a new form_data
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.Form_data.Form_dataPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Form_data400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Form_data401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Form_data422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Form_data500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Explore.Form_data.Form_dataPostResponse?> PostAsForm_dataPostResponseAsync(KClient.Models.FormDataPostSchema body, Action<RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Explore.Form_data.Form_dataPostResponse> PostAsForm_dataPostResponseAsync(KClient.Models.FormDataPostSchema body, Action<RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Form_data400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Form_data401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Form_data422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Form_data500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Explore.Form_data.Form_dataPostResponse>(requestInfo, KApi.Explore.Form_data.Form_dataPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new form_data
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.Form_data.Form_dataResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Form_data400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Form_data401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Form_data422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Form_data500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsForm_dataPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Explore.Form_data.Form_dataResponse?> PostAsync(KClient.Models.FormDataPostSchema body, Action<RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Explore.Form_data.Form_dataResponse> PostAsync(KClient.Models.FormDataPostSchema body, Action<RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Form_data400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Form_data401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Form_data422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Form_data500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Explore.Form_data.Form_dataResponse>(requestInfo, KApi.Explore.Form_data.Form_dataResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a new form_data
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPostRequestInformation(KClient.Models.FormDataPostSchema body, Action<RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPostRequestInformation(KClient.Models.FormDataPostSchema body, Action<RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Explore.Form_data.Form_dataRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Explore.Form_data.Form_dataRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Explore.Form_data.Form_dataRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Create a new form_data
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Form_dataRequestBuilderPostQueryParameters
    {
        [QueryParameter("tab_id")]
        public int? TabId { get; set; }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Form_dataRequestBuilderPostRequestConfiguration : RequestConfiguration<KApi.Explore.Form_data.Form_dataRequestBuilder.Form_dataRequestBuilderPostQueryParameters>
    {
    }
}
