using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using KClient = KiotaSupersetAPI.Client;

namespace KiotaSupersetAPI.Client;

/// <summary>
/// The main entry point of the SDK, exposes the configuration and the fluent API.
/// </summary>
[GeneratedCode("Kiota", "1.16.0")]
public partial class SupersetClient : BaseRequestBuilder
{
    /// <summary>The api property</summary>
    public KClient.Api.ApiRequestBuilder Api
    {
        get => new KClient.Api.ApiRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new <see cref="KClient.SupersetClient"/> and sets the default values.
    /// </summary>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public SupersetClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
    {
        ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
        if (string.IsNullOrEmpty(RequestAdapter.BaseUrl))
        {
            RequestAdapter.BaseUrl = "http://localhost:8080";
        }
        PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
    }
}
