
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Sqllab.Format_sql;

/// <summary>
/// Builds and executes requests for operations under \api\v1\sqllab\format_sql
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Format_sqlRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Format_sql.Format_sqlRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Format_sqlRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/format_sql", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Sqllab.Format_sql.Format_sqlRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Format_sqlRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/sqllab/format_sql", rawUrl)
    {
    }
    /// <summary>
    /// Format SQL code
    /// </summary>
    /// <returns>A <see cref="Sqllab.Format_sql.Format_sqlPostResponse"/></returns>
    /// <param name="body">Binary request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Format_sql400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Format_sql401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Format_sql403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Format_sql500Error">When receiving a 500 status code</exception>
    public async Task<Sqllab.Format_sql.Format_sqlPostResponse> PostAsFormat_sqlPostResponseAsync(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Format_sql400Error.CreateFromDiscriminatorValue },
            { "401", Models.Format_sql401Error.CreateFromDiscriminatorValue },
            { "403", Models.Format_sql403Error.CreateFromDiscriminatorValue },
            { "500", Models.Format_sql500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Sqllab.Format_sql.Format_sqlPostResponse>(requestInfo, Sqllab.Format_sql.Format_sqlPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Format SQL code
    /// </summary>
    /// <returns>A <see cref="Sqllab.Format_sql.Format_sqlResponse"/></returns>
    /// <param name="body">Binary request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Format_sql400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Format_sql401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Format_sql403Error">When receiving a 403 status code</exception>
    /// <exception cref="Models.Format_sql500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsFormat_sqlPostResponseAsync instead.")]
    public async Task<Sqllab.Format_sql.Format_sqlResponse> PostAsync(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Format_sql400Error.CreateFromDiscriminatorValue },
            { "401", Models.Format_sql401Error.CreateFromDiscriminatorValue },
            { "403", Models.Format_sql403Error.CreateFromDiscriminatorValue },
            { "500", Models.Format_sql500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Sqllab.Format_sql.Format_sqlResponse>(requestInfo, Sqllab.Format_sql.Format_sqlResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Format SQL code
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">Binary request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Stream body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        requestInfo.SetStreamContent(body, "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Sqllab.Format_sql.Format_sqlRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Format_sql.Format_sqlRequestBuilder WithUrl(string rawUrl)
    {
        return new Format_sql.Format_sqlRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Format_sqlRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
