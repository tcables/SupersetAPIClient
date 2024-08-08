
using KiotaSupersetAPI.Client.Api.V1.Datasource.Item;
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

namespace KiotaSupersetAPI.Client.Api.V1.Datasource
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\datasource
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DatasourceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.datasource.item collection</summary>
        /// <param name="position">The type of datasource</param>
        /// <returns>A <see cref="KApi.Datasource.Item.WithDatasource_typeItemRequestBuilder"/></returns>
        public KApi.Datasource.Item.WithDatasource_typeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("datasource_type", position);
                return new KApi.Datasource.Item.WithDatasource_typeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Datasource.DatasourceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatasourceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Datasource.DatasourceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DatasourceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/datasource", rawUrl)
        {
        }
    }
}
