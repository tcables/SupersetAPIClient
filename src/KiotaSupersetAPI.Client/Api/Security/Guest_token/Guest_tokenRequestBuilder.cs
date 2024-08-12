
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Security.Guest_token;

/// <summary>
/// Builds and executes requests for operations under \api\v1\security\guest_token
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Guest_tokenRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Security.Guest_token.Guest_tokenRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Guest_tokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/guest_token", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Security.Guest_token.Guest_tokenRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Guest_tokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security/guest_token", rawUrl)
    {
    }
    /// <summary>
    /// Get a guest token
    /// </summary>
    /// <returns>A <see cref="Security.Guest_token.Guest_tokenPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Guest_token400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Guest_token401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Guest_token500Error">When receiving a 500 status code</exception>
    public async Task<Security.Guest_token.Guest_tokenPostResponse> PostAsGuest_tokenPostResponseAsync(Models.GuestTokenCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Guest_token400Error.CreateFromDiscriminatorValue },
            { "401", Models.Guest_token401Error.CreateFromDiscriminatorValue },
            { "500", Models.Guest_token500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Security.Guest_token.Guest_tokenPostResponse>(requestInfo, Security.Guest_token.Guest_tokenPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a guest token
    /// </summary>
    /// <returns>A <see cref="Security.Guest_token.Guest_tokenResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Guest_token400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Guest_token401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Guest_token500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsGuest_tokenPostResponseAsync instead.")]
    public async Task<Security.Guest_token.Guest_tokenResponse> PostAsync(Models.GuestTokenCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Guest_token400Error.CreateFromDiscriminatorValue },
            { "401", Models.Guest_token401Error.CreateFromDiscriminatorValue },
            { "500", Models.Guest_token500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Security.Guest_token.Guest_tokenResponse>(requestInfo, Security.Guest_token.Guest_tokenResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get a guest token
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.GuestTokenCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Security.Guest_token.Guest_tokenRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Guest_token.Guest_tokenRequestBuilder WithUrl(string rawUrl)
    {
        return new Guest_token.Guest_tokenRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Guest_tokenRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
