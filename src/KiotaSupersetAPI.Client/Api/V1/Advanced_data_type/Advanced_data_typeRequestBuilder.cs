
using KiotaSupersetAPI.Client.Api.V1.Advanced_data_type.ConvertNamespace;
using KiotaSupersetAPI.Client.Api.V1.Advanced_data_type.Types;
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

namespace KiotaSupersetAPI.Client.Api.V1.Advanced_data_type
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\advanced_data_type
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class Advanced_data_typeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The convert property</summary>
        public KApi.Advanced_data_type.ConvertNamespace.ConvertRequestBuilder Convert
        {
            get => new KApi.Advanced_data_type.ConvertNamespace.ConvertRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The types property</summary>
        public KApi.Advanced_data_type.Types.TypesRequestBuilder Types
        {
            get => new KApi.Advanced_data_type.Types.TypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Advanced_data_type.Advanced_data_typeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Advanced_data_typeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Advanced_data_type.Advanced_data_typeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Advanced_data_typeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/advanced_data_type", rawUrl)
        {
        }
    }
}
