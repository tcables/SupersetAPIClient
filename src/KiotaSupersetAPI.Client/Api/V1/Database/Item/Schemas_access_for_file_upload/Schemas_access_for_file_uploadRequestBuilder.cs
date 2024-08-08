
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Database.Item.Schemas_access_for_file_upload;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\schemas_access_for_file_upload
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Schemas_access_for_file_uploadRequestBuilder : BaseRequestBuilder
{
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Schemas_access_for_file_uploadRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/schemas_access_for_file_upload", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Schemas_access_for_file_uploadRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/schemas_access_for_file_upload", rawUrl)
    {
    }
    /// <summary>
    /// The list of the database schemas where to upload information
    /// </summary>
    /// <returns>A <see cref="KClient.Models.DatabaseSchemaAccessForFileUploadResponse"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.DatabaseSchemaAccessForFileUploadResponse401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.DatabaseSchemaAccessForFileUploadResponse404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.DatabaseSchemaAccessForFileUploadResponse500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.DatabaseSchemaAccessForFileUploadResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "401", KClient.Models.DatabaseSchemaAccessForFileUploadResponse401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.DatabaseSchemaAccessForFileUploadResponse404Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.DatabaseSchemaAccessForFileUploadResponse500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.DatabaseSchemaAccessForFileUploadResponse>(requestInfo, KClient.Models.DatabaseSchemaAccessForFileUploadResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// The list of the database schemas where to upload information
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
    /// <returns>A <see cref="KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Database.Item.Schemas_access_for_file_upload.Schemas_access_for_file_uploadRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Schemas_access_for_file_uploadRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
    {
    }
}
