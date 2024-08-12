
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Item.Validate_sql;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\validate_sql
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Validate_sqlRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Validate_sql.Validate_sqlRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Validate_sqlRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/validate_sql", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Validate_sql.Validate_sqlRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Validate_sqlRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/validate_sql", rawUrl)
    {
    }
    /// <summary>
    /// Validates that arbitrary SQL is acceptable for the given database.
    /// </summary>
    /// <returns>A <see cref="Database.Item.Validate_sql.Validate_sqlPostResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Validate_sql400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Validate_sql401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Validate_sql404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Validate_sql500Error">When receiving a 500 status code</exception>
    public async Task<Database.Item.Validate_sql.Validate_sqlPostResponse> PostAsValidate_sqlPostResponseAsync(Models.ValidateSQLRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Validate_sql400Error.CreateFromDiscriminatorValue },
            { "401", Models.Validate_sql401Error.CreateFromDiscriminatorValue },
            { "404", Models.Validate_sql404Error.CreateFromDiscriminatorValue },
            { "500", Models.Validate_sql500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.Validate_sql.Validate_sqlPostResponse>(requestInfo, Database.Item.Validate_sql.Validate_sqlPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Validates that arbitrary SQL is acceptable for the given database.
    /// </summary>
    /// <returns>A <see cref="Database.Item.Validate_sql.Validate_sqlResponse"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.Validate_sql400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.Validate_sql401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.Validate_sql404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.Validate_sql500Error">When receiving a 500 status code</exception>
    [Obsolete("This method is obsolete. Use PostAsValidate_sqlPostResponseAsync instead.")]
    public async Task<Database.Item.Validate_sql.Validate_sqlResponse> PostAsync(Models.ValidateSQLRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.Validate_sql400Error.CreateFromDiscriminatorValue },
            { "401", Models.Validate_sql401Error.CreateFromDiscriminatorValue },
            { "404", Models.Validate_sql404Error.CreateFromDiscriminatorValue },
            { "500", Models.Validate_sql500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Database.Item.Validate_sql.Validate_sqlResponse>(requestInfo, Database.Item.Validate_sql.Validate_sqlResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Validates that arbitrary SQL is acceptable for the given database.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToPostRequestInformation(Models.ValidateSQLRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
    /// <returns>A <see cref="Database.Item.Validate_sql.Validate_sqlRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Validate_sql.Validate_sqlRequestBuilder WithUrl(string rawUrl)
    {
        return new Item.Validate_sql.Validate_sqlRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Validate_sqlRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
