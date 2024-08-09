using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;

namespace KiotaSupersetAPI.Client.API;

/// <summary>
/// Builds and executes requests for operations under \api\v1
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class SwaggerV1RequestBuilder : BaseRequestBuilder
{
    /// <summary>The advanced_data_type property</summary>
    public Advanced_data_type.Advanced_data_typeRequestBuilder Advanced_data_type
    {
        get => new Advanced_data_type.Advanced_data_typeRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The annotation_layer property</summary>
    public AnnotationLayer.Annotation_layerRequestBuilder Annotation_layer
    {
        get => new AnnotationLayer.Annotation_layerRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The assets property</summary>
    public Assets.AssetsRequestBuilder Assets
    {
        get => new Assets.AssetsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The async_event property</summary>
    public Async_event.Async_eventRequestBuilder Async_event
    {
        get => new Async_event.Async_eventRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The available_domains property</summary>
    public Available_domains.Available_domainsRequestBuilder Available_domains
    {
        get => new Available_domains.Available_domainsRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The cachekey property</summary>
    public Cachekey.CachekeyRequestBuilder Cachekey
    {
        get => new Cachekey.CachekeyRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The chart property</summary>
    public Chart.ChartRequestBuilder Chart
    {
        get => new Chart.ChartRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The css_template property</summary>
    public Css_template.Css_templateRequestBuilder Css_template
    {
        get => new Css_template.Css_templateRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The dashboard property</summary>
    public Dashboard.DashboardRequestBuilder Dashboard
    {
        get => new Dashboard.DashboardRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The database property</summary>
    public Database.DatabaseRequestBuilder Database
    {
        get => new Database.DatabaseRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The dataset property</summary>
    public Dataset.DatasetRequestBuilder Dataset
    {
        get => new Dataset.DatasetRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The datasource property</summary>
    public Datasource.DatasourceRequestBuilder Datasource
    {
        get => new Datasource.DatasourceRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The embedded_dashboard property</summary>
    public Embedded_dashboard.Embedded_dashboardRequestBuilder Embedded_dashboard
    {
        get => new Embedded_dashboard.Embedded_dashboardRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The explore property</summary>
    public Explore.ExploreRequestBuilder Explore
    {
        get => new Explore.ExploreRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The log property</summary>
    public Log.LogRequestBuilder Log
    {
        get => new Log.LogRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The me property</summary>
    public Me.MeRequestBuilder Me
    {
        get => new Me.MeRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The menu property</summary>
    public Menu.MenuRequestBuilder Menu
    {
        get => new Menu.MenuRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The query property</summary>
    public Query.QueryRequestBuilder Query
    {
        get => new Query.QueryRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The report property</summary>
    public Report.ReportRequestBuilder Report
    {
        get => new Report.ReportRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The rowlevelsecurity property</summary>
    public Rowlevelsecurity.RowlevelsecurityRequestBuilder Rowlevelsecurity
    {
        get => new Rowlevelsecurity.RowlevelsecurityRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The saved_query property</summary>
    public Saved_query.Saved_queryRequestBuilder Saved_query
    {
        get => new Saved_query.Saved_queryRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The security property</summary>
    public Security.SecurityRequestBuilder Security
    {
        get => new Security.SecurityRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The sqllab property</summary>
    public Sqllab.SqllabRequestBuilder Sqllab
    {
        get => new Sqllab.SqllabRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>The tag property</summary>
    public Tag.TagRequestBuilder Tag
    {
        get => new Tag.TagRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KAPIRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SwaggerV1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new <see cref="KAPIRequestBuilder"/> and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SwaggerV1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1", rawUrl)
    {
    }
}
