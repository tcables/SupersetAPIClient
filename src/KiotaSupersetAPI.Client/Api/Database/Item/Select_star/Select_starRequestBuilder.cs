using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API.Database.Item.Select_star;

/// <summary>
/// Builds and executes requests for operations under \api\v1\database\{pk}\select_star
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class Select_starRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the KiotaSupersetAPI.Client.API.database.item.select_star.item collection</summary>
    /// <param name="position">Table name</param>
    /// <returns>A <see cref="Database.Item.Select_star.Item.WithTable_nameItemRequestBuilder"/></returns>
    public Item.WithTable_nameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("table_name", position);
            return new Item.WithTable_nameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Select_star.Select_starRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Select_starRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/select_star", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="Database.Item.Select_star.Select_starRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public Select_starRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1/database/{pk}/select_star", rawUrl)
    {
    }
}
