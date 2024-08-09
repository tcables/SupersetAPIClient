using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Advanced_data_type;

/// <summary>
/// Builds and executes requests for operations under \api\v1\advanced_data_type
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Advanced_data_typeRequestBuilder : BaseRequestBuilder
{
    /// <summary>The convert property</summary>
    public Advanced_data_type.ConvertNamespace.ConvertRequestBuilder Convert
    {
        get => new Advanced_data_type.ConvertNamespace.ConvertRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The types property</summary>
    public Advanced_data_type.Types.TypesRequestBuilder Types
    {
        get => new Advanced_data_type.Types.TypesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="Advanced_data_type.Advanced_data_typeRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Advanced_data_typeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Advanced_data_type.Advanced_data_typeRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Advanced_data_typeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type", rawUrl)
    {
    }
}
