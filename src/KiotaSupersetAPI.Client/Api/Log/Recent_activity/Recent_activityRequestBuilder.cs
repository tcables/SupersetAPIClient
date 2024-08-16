
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Log.Recent_activity;

/// <summary>
/// Builds and executes requests for operations under \api\v1\log\recent_activity
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Recent_activityRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="API.Log.Recent_activity.Recent_activityRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Recent_activityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/log/recent_activity{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="API.Log.Recent_activity.Recent_activityRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Recent_activityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/log/recent_activity{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get recent activity data for a user
    /// </summary>
    /// <returns>A <see cref="Models.RecentActivityResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.RecentActivityResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.RecentActivityResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.RecentActivityResponseSchema403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.RecentActivityResponseSchema500Error">When receiving a 500 status code</exception>

    public async Task<Models.RecentActivityResponseSchema> GetAsync(Action<RequestConfiguration<Log.Recent_activity.Recent_activityRequestBuilder.Recent_activityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.RecentActivityResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.RecentActivityResponseSchema401Error.CreateFromDiscriminatorValue },
            { "403", Models.RecentActivityResponseSchema403Error.CreateFromDiscriminatorValue },
            { "500", Models.RecentActivityResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.RecentActivityResponseSchema>(requestInfo, Models.RecentActivityResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get recent activity data for a user
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>

    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Log.Recent_activity.Recent_activityRequestBuilder.Recent_activityRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="API.Log.Recent_activity.Recent_activityRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Recent_activity.Recent_activityRequestBuilder WithUrl(string rawUrl)
    {
        return new Recent_activity.Recent_activityRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get recent activity data for a user
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Recent_activityRequestBuilderGetQueryParameters
    {

        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Recent_activityRequestBuilderGetRequestConfiguration : RequestConfiguration<Log.Recent_activity.Recent_activityRequestBuilder.Recent_activityRequestBuilderGetQueryParameters>
    {
    }
}
