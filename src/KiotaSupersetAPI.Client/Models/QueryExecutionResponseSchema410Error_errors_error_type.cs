
using System.Runtime.Serialization;
using System;
using System.CodeDom.Compiler;
using System.Linq;

using KApi = KiotaSupersetAPI.Client.Api.V1;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client.Models
{
    [GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public enum QueryExecutionResponseSchema410Error_errors_error_type
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "FRONTEND_CSRF_ERROR")]
        #pragma warning disable CS1591
        FRONTEND_CSRF_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "FRONTEND_NETWORK_ERROR")]
        #pragma warning disable CS1591
        FRONTEND_NETWORK_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "FRONTEND_TIMEOUT_ERROR")]
        #pragma warning disable CS1591
        FRONTEND_TIMEOUT_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "GENERIC_DB_ENGINE_ERROR")]
        #pragma warning disable CS1591
        GENERIC_DB_ENGINE_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "COLUMN_DOES_NOT_EXIST_ERROR")]
        #pragma warning disable CS1591
        COLUMN_DOES_NOT_EXIST_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "TABLE_DOES_NOT_EXIST_ERROR")]
        #pragma warning disable CS1591
        TABLE_DOES_NOT_EXIST_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "SCHEMA_DOES_NOT_EXIST_ERROR")]
        #pragma warning disable CS1591
        SCHEMA_DOES_NOT_EXIST_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_INVALID_USERNAME_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_INVALID_USERNAME_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_INVALID_PASSWORD_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_INVALID_PASSWORD_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_INVALID_HOSTNAME_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_INVALID_HOSTNAME_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_PORT_CLOSED_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_PORT_CLOSED_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_INVALID_PORT_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_INVALID_PORT_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_HOST_DOWN_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_HOST_DOWN_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_ACCESS_DENIED_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_ACCESS_DENIED_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_UNKNOWN_DATABASE_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_UNKNOWN_DATABASE_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_DATABASE_PERMISSIONS_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_DATABASE_PERMISSIONS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_MISSING_PARAMETERS_ERROR")]
        #pragma warning disable CS1591
        CONNECTION_MISSING_PARAMETERS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "OBJECT_DOES_NOT_EXIST_ERROR")]
        #pragma warning disable CS1591
        OBJECT_DOES_NOT_EXIST_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "SYNTAX_ERROR")]
        #pragma warning disable CS1591
        SYNTAX_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CONNECTION_DATABASE_TIMEOUT")]
        #pragma warning disable CS1591
        CONNECTION_DATABASE_TIMEOUT,
        #pragma warning restore CS1591
        [EnumMember(Value = "VIZ_GET_DF_ERROR")]
        #pragma warning disable CS1591
        VIZ_GET_DF_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "UNKNOWN_DATASOURCE_TYPE_ERROR")]
        #pragma warning disable CS1591
        UNKNOWN_DATASOURCE_TYPE_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "FAILED_FETCHING_DATASOURCE_INFO_ERROR")]
        #pragma warning disable CS1591
        FAILED_FETCHING_DATASOURCE_INFO_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "TABLE_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        TABLE_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "DATASOURCE_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        DATASOURCE_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "DATABASE_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        DATABASE_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "QUERY_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        QUERY_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "MISSING_OWNERSHIP_ERROR")]
        #pragma warning disable CS1591
        MISSING_OWNERSHIP_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "USER_ACTIVITY_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        USER_ACTIVITY_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "DASHBOARD_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        DASHBOARD_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CHART_SECURITY_ACCESS_ERROR")]
        #pragma warning disable CS1591
        CHART_SECURITY_ACCESS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "BACKEND_TIMEOUT_ERROR")]
        #pragma warning disable CS1591
        BACKEND_TIMEOUT_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "DATABASE_NOT_FOUND_ERROR")]
        #pragma warning disable CS1591
        DATABASE_NOT_FOUND_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "MISSING_TEMPLATE_PARAMS_ERROR")]
        #pragma warning disable CS1591
        MISSING_TEMPLATE_PARAMS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_TEMPLATE_PARAMS_ERROR")]
        #pragma warning disable CS1591
        INVALID_TEMPLATE_PARAMS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "RESULTS_BACKEND_NOT_CONFIGURED_ERROR")]
        #pragma warning disable CS1591
        RESULTS_BACKEND_NOT_CONFIGURED_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "DML_NOT_ALLOWED_ERROR")]
        #pragma warning disable CS1591
        DML_NOT_ALLOWED_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_CTAS_QUERY_ERROR")]
        #pragma warning disable CS1591
        INVALID_CTAS_QUERY_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_CVAS_QUERY_ERROR")]
        #pragma warning disable CS1591
        INVALID_CVAS_QUERY_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "SQLLAB_TIMEOUT_ERROR")]
        #pragma warning disable CS1591
        SQLLAB_TIMEOUT_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "RESULTS_BACKEND_ERROR")]
        #pragma warning disable CS1591
        RESULTS_BACKEND_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "ASYNC_WORKERS_ERROR")]
        #pragma warning disable CS1591
        ASYNC_WORKERS_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "ADHOC_SUBQUERY_NOT_ALLOWED_ERROR")]
        #pragma warning disable CS1591
        ADHOC_SUBQUERY_NOT_ALLOWED_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "GENERIC_COMMAND_ERROR")]
        #pragma warning disable CS1591
        GENERIC_COMMAND_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "GENERIC_BACKEND_ERROR")]
        #pragma warning disable CS1591
        GENERIC_BACKEND_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_PAYLOAD_FORMAT_ERROR")]
        #pragma warning disable CS1591
        INVALID_PAYLOAD_FORMAT_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_PAYLOAD_SCHEMA_ERROR")]
        #pragma warning disable CS1591
        INVALID_PAYLOAD_SCHEMA_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "MARSHMALLOW_ERROR")]
        #pragma warning disable CS1591
        MARSHMALLOW_ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "REPORT_NOTIFICATION_ERROR")]
        #pragma warning disable CS1591
        REPORT_NOTIFICATION_ERROR,
        #pragma warning restore CS1591
    }
}
