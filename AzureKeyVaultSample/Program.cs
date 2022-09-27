using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace AzureKeyVaultSample;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string keyVaultURL = "kvUrl1";
        string tenantId = "tenantId";
        string clientId = "clientId";
        string clientSecret = "clientSecret";


        var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
        var client = new SecretClient(new Uri(keyVaultURL), credential);
        var secret = client.GetSecret("SQLConnectionString");

        string sqlConnectionString = secret.Value.Value;
    }

}

