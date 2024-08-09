
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.API.Database.Item.Schemas;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\schemas
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class SchemasRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Schemas.SchemasRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SchemasRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/schemas{?q*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Schemas.SchemasRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SchemasRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/schemas{?q*}", rawUrl)
    {
    }
    /// <summary>
    /// Get all schemas from a database
    /// </summary>
    /// <returns>A <see cref="KClient.Models.SchemasResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.SchemasResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.SchemasResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.SchemasResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.SchemasResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.SchemasResponseSchema> GetAsync(Action<RequestConfiguration<Database.Item.Schemas.SchemasRequestBuilder.SchemasRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.SchemasResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.SchemasResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.SchemasResponseSchema404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.SchemasResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.SchemasResponseSchema>(requestInfo, KClient.Models.SchemasResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get all schemas from a database
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Database.Item.Schemas.SchemasRequestBuilder.SchemasRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Database.Item.Schemas.SchemasRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public Database.Item.Schemas.SchemasRequestBuilder WithUrl(string rawUrl)
    {
        return new Database.Item.Schemas.SchemasRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Get all schemas from a database
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class SchemasRequestBuilderGetQueryParameters
    {
        [QueryParameter("q")]
        public string Q { get; set; }

    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class SchemasRequestBuilderGetRequestConfiguration : RequestConfiguration<Database.Item.Schemas.SchemasRequestBuilder.SchemasRequestBuilderGetQueryParameters>
    {
    }
}
