using KiotaSupersetAPI.Client;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace KiotaSupersetAPI.Demo;

internal class Program
{
    static async Task Main(string[] args)
    {
        const string SUPERSET_INSTANCE = "http://localhost:8080/";

        string username = "admin";
        string password = "admin";
        int databaseId = 2; // Replace with your actual database ID
        string tableName = "your_table_name";

        //BaseBearerTokenAuthenticationProvider
        var authProvider = new SuperSetAuthenticationProvider(
            SUPERSET_INSTANCE, username, password);

        // Create request adapter using the HttpClient-based implementation
        var adapter = new HttpClientRequestAdapter(authProvider);

        // Create the API client

        var client = new SupersetAPIClient(adapter);

        KiotaSupersetAPI.Client.API.Database.DatabaseGetResponse databases = await
            client.API.V1.Database.GetDatabaseGetResponseAsync();

        foreach (var database in databases.Result)
        {
            Console.WriteLine($"Database: {database.DatabaseName}");
        }

        KiotaSupersetAPI.Client.API.Dataset.DatasetGetResponse datasets = await
            client.API.V1.Dataset.GetDatasetsPagedGetResponseAsync(
                new(1, 5));

        foreach (var dataset in datasets.Result)
        {
            Console.WriteLine($"Dataset: {dataset.TableName}");
        }
    }
}
