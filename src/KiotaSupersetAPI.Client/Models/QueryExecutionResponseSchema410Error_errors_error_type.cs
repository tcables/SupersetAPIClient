using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KiotaSupersetAPI.Client.Models;

[GeneratedCode("Kiota", "1.16.0")]
public enum QueryExecutionResponseSchema410Error_errors_error_type
{
    [EnumMember(Value = "FRONTEND_CSRF_ERROR")]
    FRONTEND_CSRF_ERROR,
    [EnumMember(Value = "FRONTEND_NETWORK_ERROR")]
    FRONTEND_NETWORK_ERROR,
    [EnumMember(Value = "FRONTEND_TIMEOUT_ERROR")]
    FRONTEND_TIMEOUT_ERROR,
    [EnumMember(Value = "GENERIC_DB_ENGINE_ERROR")]
    GENERIC_DB_ENGINE_ERROR,
    [EnumMember(Value = "COLUMN_DOES_NOT_EXIST_ERROR")]
    COLUMN_DOES_NOT_EXIST_ERROR,
    [EnumMember(Value = "TABLE_DOES_NOT_EXIST_ERROR")]
    TABLE_DOES_NOT_EXIST_ERROR,
    [EnumMember(Value = "SCHEMA_DOES_NOT_EXIST_ERROR")]
    SCHEMA_DOES_NOT_EXIST_ERROR,
    [EnumMember(Value = "CONNECTION_INVALID_USERNAME_ERROR")]
    CONNECTION_INVALID_USERNAME_ERROR,
    [EnumMember(Value = "CONNECTION_INVALID_PASSWORD_ERROR")]
    CONNECTION_INVALID_PASSWORD_ERROR,
    [EnumMember(Value = "CONNECTION_INVALID_HOSTNAME_ERROR")]
    CONNECTION_INVALID_HOSTNAME_ERROR,
    [EnumMember(Value = "CONNECTION_PORT_CLOSED_ERROR")]
    CONNECTION_PORT_CLOSED_ERROR,
    [EnumMember(Value = "CONNECTION_INVALID_PORT_ERROR")]
    CONNECTION_INVALID_PORT_ERROR,
    [EnumMember(Value = "CONNECTION_HOST_DOWN_ERROR")]
    CONNECTION_HOST_DOWN_ERROR,
    [EnumMember(Value = "CONNECTION_ACCESS_DENIED_ERROR")]
    CONNECTION_ACCESS_DENIED_ERROR,
    [EnumMember(Value = "CONNECTION_UNKNOWN_DATABASE_ERROR")]
    CONNECTION_UNKNOWN_DATABASE_ERROR,
    [EnumMember(Value = "CONNECTION_DATABASE_PERMISSIONS_ERROR")]
    CONNECTION_DATABASE_PERMISSIONS_ERROR,
    [EnumMember(Value = "CONNECTION_MISSING_PARAMETERS_ERROR")]
    CONNECTION_MISSING_PARAMETERS_ERROR,
    [EnumMember(Value = "OBJECT_DOES_NOT_EXIST_ERROR")]
    OBJECT_DOES_NOT_EXIST_ERROR,
    [EnumMember(Value = "SYNTAX_ERROR")]
    SYNTAX_ERROR,
    [EnumMember(Value = "CONNECTION_DATABASE_TIMEOUT")]
    CONNECTION_DATABASE_TIMEOUT,
    [EnumMember(Value = "VIZ_GET_DF_ERROR")]
    VIZ_GET_DF_ERROR,
    [EnumMember(Value = "UNKNOWN_DATASOURCE_TYPE_ERROR")]
    UNKNOWN_DATASOURCE_TYPE_ERROR,
    [EnumMember(Value = "FAILED_FETCHING_DATASOURCE_INFO_ERROR")]
    FAILED_FETCHING_DATASOURCE_INFO_ERROR,
    [EnumMember(Value = "TABLE_SECURITY_ACCESS_ERROR")]
    TABLE_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "DATASOURCE_SECURITY_ACCESS_ERROR")]
    DATASOURCE_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "DATABASE_SECURITY_ACCESS_ERROR")]
    DATABASE_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "QUERY_SECURITY_ACCESS_ERROR")]
    QUERY_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "MISSING_OWNERSHIP_ERROR")]
    MISSING_OWNERSHIP_ERROR,
    [EnumMember(Value = "USER_ACTIVITY_SECURITY_ACCESS_ERROR")]
    USER_ACTIVITY_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "DASHBOARD_SECURITY_ACCESS_ERROR")]
    DASHBOARD_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "CHART_SECURITY_ACCESS_ERROR")]
    CHART_SECURITY_ACCESS_ERROR,
    [EnumMember(Value = "BACKEND_TIMEOUT_ERROR")]
    BACKEND_TIMEOUT_ERROR,
    [EnumMember(Value = "DATABASE_NOT_FOUND_ERROR")]
    DATABASE_NOT_FOUND_ERROR,
    [EnumMember(Value = "MISSING_TEMPLATE_PARAMS_ERROR")]
    MISSING_TEMPLATE_PARAMS_ERROR,
    [EnumMember(Value = "INVALID_TEMPLATE_PARAMS_ERROR")]
    INVALID_TEMPLATE_PARAMS_ERROR,
    [EnumMember(Value = "RESULTS_BACKEND_NOT_CONFIGURED_ERROR")]
    RESULTS_BACKEND_NOT_CONFIGURED_ERROR,
    [EnumMember(Value = "DML_NOT_ALLOWED_ERROR")]
    DML_NOT_ALLOWED_ERROR,
    [EnumMember(Value = "INVALID_CTAS_QUERY_ERROR")]
    INVALID_CTAS_QUERY_ERROR,
    [EnumMember(Value = "INVALID_CVAS_QUERY_ERROR")]
    INVALID_CVAS_QUERY_ERROR,
    [EnumMember(Value = "SQLLAB_TIMEOUT_ERROR")]
    SQLLAB_TIMEOUT_ERROR,
    [EnumMember(Value = "RESULTS_BACKEND_ERROR")]
    RESULTS_BACKEND_ERROR,
    [EnumMember(Value = "ASYNC_WORKERS_ERROR")]
    ASYNC_WORKERS_ERROR,
    [EnumMember(Value = "ADHOC_SUBQUERY_NOT_ALLOWED_ERROR")]
    ADHOC_SUBQUERY_NOT_ALLOWED_ERROR,
    [EnumMember(Value = "GENERIC_COMMAND_ERROR")]
    GENERIC_COMMAND_ERROR,
    [EnumMember(Value = "GENERIC_BACKEND_ERROR")]
    GENERIC_BACKEND_ERROR,
    [EnumMember(Value = "INVALID_PAYLOAD_FORMAT_ERROR")]
    INVALID_PAYLOAD_FORMAT_ERROR,
    [EnumMember(Value = "INVALID_PAYLOAD_SCHEMA_ERROR")]
    INVALID_PAYLOAD_SCHEMA_ERROR,
    [EnumMember(Value = "MARSHMALLOW_ERROR")]
    MARSHMALLOW_ERROR,
    [EnumMember(Value = "REPORT_NOTIFICATION_ERROR")]
    REPORT_NOTIFICATION_ERROR,
}
