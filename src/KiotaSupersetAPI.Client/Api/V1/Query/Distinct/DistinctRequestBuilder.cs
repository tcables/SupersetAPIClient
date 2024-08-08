
using KiotaSupersetAPI.Client.Api.V1.Query.Distinct.Item;
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

namespace KiotaSupersetAPI.Client.Api.V1.Query.Distinct
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1\query\distinct
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class DistinctRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KiotaSupersetAPI.Client.api.v1.query.distinct.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="KApi.Query.Distinct.Item.WithColumn_nameItemRequestBuilder"/></returns>
        public KApi.Query.Distinct.Item.WithColumn_nameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("column_name", position);
                return new KApi.Query.Distinct.Item.WithColumn_nameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Query.Distinct.DistinctRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DistinctRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/distinct", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.Query.Distinct.DistinctRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DistinctRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/query/distinct", rawUrl)
        {
        }
    }
}
