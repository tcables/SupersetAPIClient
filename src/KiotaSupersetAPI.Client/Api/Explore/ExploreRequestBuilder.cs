
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;

namespace KiotaSupersetAPI.Client.API.Explore;

/// <summary>
/// Builds and executes requests for operations under \api\v1\explore
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class ExploreRequestBuilder : BaseRequestBuilder
{
    /// <summary>The form_data property</summary>
    public Form_data.Form_dataRequestBuilder Form_data
    {
        get => new Explore.Form_data.Form_dataRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The permalink property</summary>
    public Permalink.PermalinkRequestBuilder Permalink
    {
        get => new Explore.Permalink.PermalinkRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Explore.ExploreRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExploreRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore{?datasource_id*,datasource_type*,form_data_key*,permalink_key*,slice_id*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Explore.ExploreRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public ExploreRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/explore{?datasource_id*,datasource_type*,form_data_key*,permalink_key*,slice_id*}", rawUrl)
    {
    }
    /// <summary>
    /// Assembles Explore related information (form_data, slice, dataset) in a single endpoint.&lt;br/&gt;&lt;br/&gt; The information can be assembled from:&lt;br/&gt; - The cache using a form_data_key&lt;br/&gt; - The metadata database using a permalink_key&lt;br/&gt; - Build from scratch using dataset or slice identifiers.
    /// </summary>
    /// <returns>A <see cref="Models.ExploreContextSchema"/></returns>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <exception cref="Models.ExploreContextSchema400Error">When receiving a 400 status code</exception>
    /// <exception cref="Models.ExploreContextSchema401Error">When receiving a 401 status code</exception>
    /// <exception cref="Models.ExploreContextSchema404Error">When receiving a 404 status code</exception>
    /// <exception cref="Models.ExploreContextSchema422Error">When receiving a 422 status code</exception>
    /// <exception cref="Models.ExploreContextSchema500Error">When receiving a 500 status code</exception>
    public async Task<Models.ExploreContextSchema> GetAsync(Action<RequestConfiguration<Explore.ExploreRequestBuilder.ExploreRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
    {

        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
        {
            { "400", Models.ExploreContextSchema400Error.CreateFromDiscriminatorValue },
            { "401", Models.ExploreContextSchema401Error.CreateFromDiscriminatorValue },
            { "404", Models.ExploreContextSchema404Error.CreateFromDiscriminatorValue },
            { "422", Models.ExploreContextSchema422Error.CreateFromDiscriminatorValue },
            { "500", Models.ExploreContextSchema500Error.CreateFromDiscriminatorValue },
        };
        return await RequestAdapter.SendAsync<Models.ExploreContextSchema>(requestInfo, Models.ExploreContextSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>
    /// Assembles Explore related information (form_data, slice, dataset) in a single endpoint.&lt;br/&gt;&lt;br/&gt; The information can be assembled from:&lt;br/&gt; - The cache using a form_data_key&lt;br/&gt; - The metadata database using a permalink_key&lt;br/&gt; - Build from scratch using dataset or slice identifiers.
    /// </summary>
    /// <returns>A <see cref="RequestInformation"/></returns>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Explore.ExploreRequestBuilder.ExploreRequestBuilderGetQueryParameters>> requestConfiguration = default)
    {

        var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
        requestInfo.Configure(requestConfiguration);
        requestInfo.Headers.TryAdd("Accept", "application/json");
        return requestInfo;
    }
    /// <summary>
    /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
    /// </summary>
    /// <returns>A <see cref="Explore.ExploreRequestBuilder"/></returns>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    public ExploreRequestBuilder WithUrl(string rawUrl)
    {
        return new Explore.ExploreRequestBuilder(rawUrl, RequestAdapter);
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
    public partial class ExploreRequestBuilderGetRequestConfiguration : RequestConfiguration<Explore.ExploreRequestBuilder.ExploreRequestBuilderGetQueryParameters>
    {
    }
}
