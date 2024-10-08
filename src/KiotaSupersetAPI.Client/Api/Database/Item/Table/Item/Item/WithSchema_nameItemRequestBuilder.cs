
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Database.Item.Table.Item.Item;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\table\{table_name}\{schema_name}
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class WithSchema_nameItemRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Table.Item.Item.WithSchema_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithSchema_nameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table/{table_name}/{schema_name}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Table.Item.Item.WithSchema_nameItemRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public WithSchema_nameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/table/{table_name}/{schema_name}", rawUrl)
    {
    }
    /// <summary>
    /// Get database table metadata
    /// </summary>
    /// <returns>A <see cref="Models.TableMetadataResponseSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.TableMetadataResponseSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.TableMetadataResponseSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.TableMetadataResponseSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.TableMetadataResponseSchema422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.TableMetadataResponseSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.TableMetadataResponseSchema> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.TableMetadataResponseSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.TableMetadataResponseSchema401Error.CreateFromDiscriminatorValue },
            { "404", Models.TableMetadataResponseSchema404Error.CreateFromDiscriminatorValue },
            { "422", Models.TableMetadataResponseSchema422Error.CreateFromDiscriminatorValue },
            { "500", Models.TableMetadataResponseSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.TableMetadataResponseSchema>(requestInfo, Models.TableMetadataResponseSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Get database table metadata
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Database.Item.Table.Item.Item.WithSchema_nameItemRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public WithSchema_nameItemRequestBuilder WithUrl(string rawUrl)
    {
        return new WithSchema_nameItemRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithSchema_nameItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
