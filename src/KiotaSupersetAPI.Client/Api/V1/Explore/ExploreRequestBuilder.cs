
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.V1.Explore;

/// <summary>
/// Builds and executes requests for operations under \api\v1\explore
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ExploreRequestBuilder : BaseRequestBuilder
{
    /// <summary>The form_data property</summary>
    public KApi.Explore.Form_data.Form_dataRequestBuilder Form_data
    {
        get => new KApi.Explore.Form_data.Form_dataRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The permalink property</summary>
    public KApi.Explore.Permalink.PermalinkRequestBuilder Permalink
    {
        get => new KApi.Explore.Permalink.PermalinkRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Explore.ExploreRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExploreRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore{?datasource_id*,datasource_type*,form_data_key*,permalink_key*,slice_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KApi.Explore.ExploreRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExploreRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore{?datasource_id*,datasource_type*,form_data_key*,permalink_key*,slice_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Assembles Explore related information (form_data, slice, dataset) in a single endpoint.&lt;br/&gt;&lt;br/&gt; The information can be assembled from:&lt;br/&gt; - The cache using a form_data_key&lt;br/&gt; - The metadata database using a permalink_key&lt;br/&gt; - Build from scratch using dataset or slice identifiers.
    /// </summary>
    /// <returns>A <see cref="KClient.Models.ExploreContextSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="KClient.Models.ExploreContextSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="KClient.Models.ExploreContextSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="KClient.Models.ExploreContextSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="KClient.Models.ExploreContextSchema422Error">When receiving a 422 status code</exception>
    /// <exception cref="KClient.Models.ExploreContextSchema500Error">When receiving a 500 status code</exception>
    public async Task<KClient.Models.ExploreContextSchema> GetAsync(Action<RequestConfiguration<KApi.Explore.ExploreRequestBuilder.ExploreRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", KClient.Models.ExploreContextSchema400Error.CreateFromDiscriminatorValue },
            { "401", KClient.Models.ExploreContextSchema401Error.CreateFromDiscriminatorValue },
            { "404", KClient.Models.ExploreContextSchema404Error.CreateFromDiscriminatorValue },
            { "422", KClient.Models.ExploreContextSchema422Error.CreateFromDiscriminatorValue },
            { "500", KClient.Models.ExploreContextSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<KClient.Models.ExploreContextSchema>(requestInfo, KClient.Models.ExploreContextSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Assembles Explore related information (form_data, slice, dataset) in a single endpoint.&lt;br/&gt;&lt;br/&gt; The information can be assembled from:&lt;br/&gt; - The cache using a form_data_key&lt;br/&gt; - The metadata database using a permalink_key&lt;br/&gt; - Build from scratch using dataset or slice identifiers.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KApi.Explore.ExploreRequestBuilder.ExploreRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="KApi.Explore.ExploreRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public KApi.Explore.ExploreRequestBuilder WithUrl(string rawUrl)
    {
        return new KApi.Explore.ExploreRequestBuilder(rawUrl, RequestAdapter);
    }
    /// <summary>
    /// Assembles Explore related information (form_data, slice, dataset) in a single endpoint.&lt;br/&gt;&lt;br/&gt; The information can be assembled from:&lt;br/&gt; - The cache using a form_data_key&lt;br/&gt; - The metadata database using a permalink_key&lt;br/&gt; - Build from scratch using dataset or slice identifiers.
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ExploreRequestBuilderGetQueryParameters
    {
        [QueryParameter("datasource_id")]
        public int? DatasourceId { get; set; }
        [QueryParameter("datasource_type")]
        public string DatasourceType { get; set; }

        [QueryParameter("form_data_key")]
        public string FormDataKey { get; set; }

        [QueryParameter("permalink_key")]
        public string PermalinkKey { get; set; }

        [QueryParameter("slice_id")]
        public int? SliceId { get; set; }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class ExploreRequestBuilderGetRequestConfiguration : RequestConfiguration<KApi.Explore.ExploreRequestBuilder.ExploreRequestBuilderGetQueryParameters>
    {
    }
}
