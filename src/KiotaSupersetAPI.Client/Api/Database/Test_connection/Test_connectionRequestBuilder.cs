
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Test_connection;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\test_connection
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Test_connectionRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Database.Test_connection.Test_connectionRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Test_connectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/test_connection", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Test_connection.Test_connectionRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Test_connectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/test_connection", rawUrl)
    {
    }
    /// <summary>
    /// Test a database connection
    /// </summary>
    /// <returns>A <see cref="Database.Test_connection.Test_connectionPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Test_connection400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Test_connection422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Test_connection500Error">When receiving a 500 status code</exception>
    public async Task<Database.Test_connection.Test_connectionPostResponse> PostAsTest_connectionPostResponseAsync(Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Test_connection400Error.CreateFromDiscriminatorValue },
            { "422", Models.Test_connection422Error.CreateFromDiscriminatorValue },
            { "500", Models.Test_connection500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Test_connection.Test_connectionPostResponse>(requestInfo, Database.Test_connection.Test_connectionPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Test a database connection
    /// </summary>
    /// <returns>A <see cref="Database.Test_connection.Test_connectionResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Test_connection400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Test_connection422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.Test_connection500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsTest_connectionPostResponseAsync instead.")]
    public async Task<Database.Test_connection.Test_connectionResponse> PostAsync(Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Test_connection400Error.CreateFromDiscriminatorValue },
            { "422", Models.Test_connection422Error.CreateFromDiscriminatorValue },
            { "500", Models.Test_connection500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Test_connection.Test_connectionResponse>(requestInfo, Database.Test_connection.Test_connectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Test a database connection
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.DatabaseTestConnectionSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Database.Test_connection.Test_connectionRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Test_connection.Test_connectionRequestBuilder WithUrl(string rawUrl)
    {
        return new Database.Test_connection.Test_connectionRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Test_connectionRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
