// <auto-generated/>
using KiotaSupersetAPI.Client.Api.V1.Datasource.Item.Item.Column;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using Api = KiotaSupersetAPI.Client.Api.V1;

namespace KiotaSupersetAPI.Client.Api.V1.Datasource.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\datasource\{datasource_type}\{datasource_id}
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class WithDatasource_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The column property</summary>
        public global::KiotaSupersetAPI.Client.Api.V1.Datasource.Item.Item.Column.ColumnRequestBuilder Column
        {
            get => new global::KiotaSupersetAPI.Client.Api.V1.Datasource.Item.Item.Column.ColumnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Datasource.Item.Item.WithDatasource_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDatasource_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KiotaSupersetAPI.Client.Api.V1.Datasource.Item.Item.WithDatasource_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithDatasource_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource/{datasource_type}/{datasource_id}", rawUrl)
        {
        }
    }
}
