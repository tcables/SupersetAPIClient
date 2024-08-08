
using KiotaSupersetAPI.Client.Api.V1.Security.Csrf_token;
using KiotaSupersetAPI.Client.Api.V1.Security.Guest_token;
using KiotaSupersetAPI.Client.Api.V1.Security.Login;
using KiotaSupersetAPI.Client.Api.V1.Security.Refresh;
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

namespace KiotaSupersetAPI.Client.Api.V1.Security
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\security
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class SecurityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The csrf_token property</summary>
        public KApi.Security.Csrf_token.Csrf_tokenRequestBuilder Csrf_token
        {
            get => new KApi.Security.Csrf_token.Csrf_tokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The guest_token property</summary>
        public KApi.Security.Guest_token.Guest_tokenRequestBuilder Guest_token
        {
            get => new KApi.Security.Guest_token.Guest_tokenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The login property</summary>
        public KApi.Security.Login.LoginRequestBuilder Login
        {
            get => new KApi.Security.Login.LoginRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The refresh property</summary>
        public KApi.Security.Refresh.RefreshRequestBuilder Refresh
        {
            get => new KApi.Security.Refresh.RefreshRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Security.SecurityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Security.SecurityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SecurityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/security", rawUrl)
        {
        }
    }
}
