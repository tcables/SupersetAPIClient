
using KiotaSupersetAPI.Client.Api.Item._openapi;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Api.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\{version}
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithVersionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The _openapi property</summary>
        public KClient.Api.Item._openapi._openapiRequestBuilder _openapi
        {
            get => new KClient.Api.Item._openapi._openapiRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KClient.Api.Item.WithVersionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithVersionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/{version}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KClient.Api.Item.WithVersionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithVersionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/{version}", rawUrl)
        {
        }
    }
}
