
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KiotaSupersetAPI.Client.Api.V1.Css_template._info;
using KiotaSupersetAPI.Client.Api.V1.Css_template.Item;
using KiotaSupersetAPI.Client.Api.V1.Css_template.Related;
using KiotaSupersetAPI.Client.Models;
using KiotaSupersetAPI.Client.Models.CssTemplateRestApi;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Css_template;

/// <summary>
/// Builds and executes requests for operations under \api\v1\css_template
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Css_templateRequestBuilder : BaseRequestBuilder
{
    /// <summary>The _info property</summary>
    public KApi.Css_template._info._infoRequestBuilder _info
    {
        get => new KApi.Css_template._info._infoRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The related property</summary>
    public KApi.Css_template.Related.RelatedRequestBuilder Related
    {
        get => new KApi.Css_template.Related.RelatedRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.css_template.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Css_template.Item.WithPkItemRequestBuilder"/></returns>
    public KApi.Css_template.Item.WithPkItemRequestBuilder this[int position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("pk", position);
            return new KApi.Css_template.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.css_template.item collection</summary>
    /// <param name="position">Unique identifier of the item</param>
    /// <returns>A <see cref="KApi.Css_template.Item.WithPkItemRequestBuilder"/></returns>
    [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
    public KApi.Css_template.Item.WithPkItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("pk", position);
            return new KApi.Css_template.Item.WithPkItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Css_template.Css_templateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Css_templateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/css_template{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Css_template.Css_templateRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Css_templateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/css_template{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Bulk delete CSS templates
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templateDeleteResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Css_template401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Css_template404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Css_template422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Css_template500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Css_template.Css_templateDeleteResponse?> DeleteAsCss_templateDeleteResponseAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Css_template.Css_templateDeleteResponse> DeleteAsCss_templateDeleteResponseAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Css_template401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Css_template404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Css_template422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Css_template500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Css_template.Css_templateDeleteResponse>(requestInfo, KApi.Css_template.Css_templateDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete CSS templates
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templateResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Css_template401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Css_template404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.Css_template422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Css_template500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use DeleteAsCss_templateDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Css_template.Css_templateResponse?> DeleteAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Css_template.Css_templateResponse> DeleteAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToDeleteRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.Css_template401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.Css_template404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Css_template422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Css_template500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Css_template.Css_templateResponse>(requestInfo, KApi.Css_template.Css_templateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of CSS templates, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templateGetResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Css_template400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Css_template401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Css_template422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Css_template500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Css_template.Css_templateGetResponse?> GetAsCss_templateGetResponseAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Css_template.Css_templateGetResponse> GetAsCss_templateGetResponseAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Css_template400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Css_template401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Css_template422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Css_template500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Css_template.Css_templateGetResponse>(requestInfo, KApi.Css_template.Css_templateGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Gets a list of CSS templates, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templateResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Css_template400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Css_template401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Css_template422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Css_template500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use GetAsCss_templateGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Css_template.Css_templateResponse?> GetAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Css_template.Css_templateResponse> GetAsync(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Css_template400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Css_template401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Css_template422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Css_template500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Css_template.Css_templateResponse>(requestInfo, KApi.Css_template.Css_templateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a CSS template
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templatePostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Css_template400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Css_template401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Css_template422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Css_template500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Css_template.Css_templatePostResponse?> PostAsCss_templatePostResponseAsync(KClient.Models.CssTemplateRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Css_template.Css_templatePostResponse> PostAsCss_templatePostResponseAsync(KClient.Models.CssTemplateRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Css_template400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Css_template401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Css_template422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Css_template500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Css_template.Css_templatePostResponse>(requestInfo, KApi.Css_template.Css_templatePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Create a CSS template
    /// </summary>
    /// <returns>A <see cref="KApi.Css_template.Css_templateResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.Css_template400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.Css_template401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.Css_template422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.Css_template500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsCss_templatePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<KApi.Css_template.Css_templateResponse?> PostAsync(KClient.Models.CssTemplateRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<KApi.Css_template.Css_templateResponse> PostAsync(KClient.Models.CssTemplateRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.Css_template400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.Css_template401Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.Css_template422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.Css_template500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KApi.Css_template.Css_templateResponse>(requestInfo, KApi.Css_template.Css_templateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Bulk delete CSS templates
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Gets a list of CSS templates, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {
#endif
        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Create a CSS template
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPostRequestInformation(KClient.Models.CssTemplateRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPostRequestInformation(KClient.Models.CssTemplateRestApi.Post body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="KApi.Css_template.Css_templateRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Css_template.Css_templateRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Css_template.Css_templateRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Bulk delete CSS templates
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Css_templateRequestBuilderDeleteQueryParameters
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        [QueryParameter("q")]
        public string? Q { get; set; }
#nullable restore
#else
        [QueryParameter("q")]
        public string Q { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Css_templateRequestBuilderDeleteRequestConfiguration : RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderDeleteQueryParameters>
    {
    }
    /// <summary>
    /// Gets a list of CSS templates, use Rison or JSON query parameters for filtering, sorting, pagination and for selecting specific columns and metadata.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Css_templateRequestBuilderGetQueryParameters
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        [QueryParameter("q")]
        public string? Q { get; set; }
#nullable restore
#else
        [QueryParameter("q")]
        public string Q { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Css_templateRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Css_template.Css_templateRequestBuilder.Css_templateRequestBuilderGetQueryParameters>
    {
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Css_templateRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
