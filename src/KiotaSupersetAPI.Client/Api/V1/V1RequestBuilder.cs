
using KiotaSupersetAPI.Client.Api.V1.Advanced_data_type;
using KiotaSupersetAPI.Client.Api.V1.Annotation_layer;
using KiotaSupersetAPI.Client.Api.V1.Assets;
using KiotaSupersetAPI.Client.Api.V1.Async_event;
using KiotaSupersetAPI.Client.Api.V1.Available_domains;
using KiotaSupersetAPI.Client.Api.V1.Cachekey;
using KiotaSupersetAPI.Client.Api.V1.Chart;
using KiotaSupersetAPI.Client.Api.V1.Css_template;
using KiotaSupersetAPI.Client.Api.V1.Dashboard;
using KiotaSupersetAPI.Client.Api.V1.Database;
using KiotaSupersetAPI.Client.Api.V1.Dataset;
using KiotaSupersetAPI.Client.Api.V1.Datasource;
using KiotaSupersetAPI.Client.Api.V1.Embedded_dashboard;
using KiotaSupersetAPI.Client.Api.V1.Explore;
using KiotaSupersetAPI.Client.Api.V1.Log;
using KiotaSupersetAPI.Client.Api.V1.Me;
using KiotaSupersetAPI.Client.Api.V1.Menu;
using KiotaSupersetAPI.Client.Api.V1.Query;
using KiotaSupersetAPI.Client.Api.V1.Report;
using KiotaSupersetAPI.Client.Api.V1.Rowlevelsecurity;
using KiotaSupersetAPI.Client.Api.V1.Saved_query;
using KiotaSupersetAPI.Client.Api.V1.Security;
using KiotaSupersetAPI.Client.Api.V1.Sqllab;
using KiotaSupersetAPI.Client.Api.V1.Tag;
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

namespace KiotaSupersetAPI.Client.Api.V1
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v1
    /// </summary>
    [GeneratedCode("Kiota", "1.16.0")]
    public partial class V1RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The advanced_data_type property</summary>
        public KApi.Advanced_data_type.Advanced_data_typeRequestBuilder Advanced_data_type
        {
            get => new KApi.Advanced_data_type.Advanced_data_typeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The annotation_layer property</summary>
        public KApi.Annotation_layer.Annotation_layerRequestBuilder Annotation_layer
        {
            get => new KApi.Annotation_layer.Annotation_layerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assets property</summary>
        public KApi.Assets.AssetsRequestBuilder Assets
        {
            get => new KApi.Assets.AssetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The async_event property</summary>
        public KApi.Async_event.Async_eventRequestBuilder Async_event
        {
            get => new KApi.Async_event.Async_eventRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The available_domains property</summary>
        public KApi.Available_domains.Available_domainsRequestBuilder Available_domains
        {
            get => new KApi.Available_domains.Available_domainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cachekey property</summary>
        public KApi.Cachekey.CachekeyRequestBuilder Cachekey
        {
            get => new KApi.Cachekey.CachekeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chart property</summary>
        public KApi.Chart.ChartRequestBuilder Chart
        {
            get => new KApi.Chart.ChartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The css_template property</summary>
        public KApi.Css_template.Css_templateRequestBuilder Css_template
        {
            get => new KApi.Css_template.Css_templateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dashboard property</summary>
        public KApi.Dashboard.DashboardRequestBuilder Dashboard
        {
            get => new KApi.Dashboard.DashboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The database property</summary>
        public KApi.Database.DatabaseRequestBuilder Database
        {
            get => new KApi.Database.DatabaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataset property</summary>
        public KApi.Dataset.DatasetRequestBuilder Dataset
        {
            get => new KApi.Dataset.DatasetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The datasource property</summary>
        public KApi.Datasource.DatasourceRequestBuilder Datasource
        {
            get => new KApi.Datasource.DatasourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The embedded_dashboard property</summary>
        public KApi.Embedded_dashboard.Embedded_dashboardRequestBuilder Embedded_dashboard
        {
            get => new KApi.Embedded_dashboard.Embedded_dashboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The explore property</summary>
        public KApi.Explore.ExploreRequestBuilder Explore
        {
            get => new KApi.Explore.ExploreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The log property</summary>
        public KApi.Log.LogRequestBuilder Log
        {
            get => new KApi.Log.LogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The me property</summary>
        public KApi.Me.MeRequestBuilder Me
        {
            get => new KApi.Me.MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The menu property</summary>
        public KApi.Menu.MenuRequestBuilder Menu
        {
            get => new KApi.Menu.MenuRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The query property</summary>
        public KApi.Query.QueryRequestBuilder Query
        {
            get => new KApi.Query.QueryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The report property</summary>
        public KApi.Report.ReportRequestBuilder Report
        {
            get => new KApi.Report.ReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rowlevelsecurity property</summary>
        public KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder Rowlevelsecurity
        {
            get => new KApi.Rowlevelsecurity.RowlevelsecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The saved_query property</summary>
        public KApi.Saved_query.Saved_queryRequestBuilder Saved_query
        {
            get => new KApi.Saved_query.Saved_queryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The security property</summary>
        public KApi.Security.SecurityRequestBuilder Security
        {
            get => new KApi.Security.SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sqllab property</summary>
        public KApi.Sqllab.SqllabRequestBuilder Sqllab
        {
            get => new KApi.Sqllab.SqllabRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tag property</summary>
        public KApi.Tag.TagRequestBuilder Tag
        {
            get => new KApi.Tag.TagRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KApi.V1RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public V1RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v1", rawUrl)
        {
        }
    }
}
