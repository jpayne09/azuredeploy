using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;
//using Microsoft.Azure.Management.Subscription;

namespace azuredeploy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AzureDataController : ControllerBase
    {            
    
        public ClientSecretCredential setCredential(){
        var credential = new ClientSecretCredential("c22265e7-900b-49c0-ac66-cf43cbb73b9f", "29b80fb6-a004-4343-8052-dc632e62a3d0", "xvzNSv.o3Yf5cZyDdJprkg1Pycv-zbm5~.");
        return credential;
        }

            public static async Task RunSample()
            {
                var credential = new ClientSecretCredential("c22265e7-900b-49c0-ac66-cf43cbb73b9f", "29b80fb6-a004-4343-8052-dc632e62a3d0", "xvzNSv.o3Yf5cZyDdJprkg1Pycv-zbm5~.");
                string subscriptionId = "2c308107-f204-43da-8bcb-f922f5148d9f";
                string storageAccountName = "rgstorage3333";
                string region = "eastus";

                var storageManagementClient = new StorageManagementClient(subscriptionId, credential);
                var storageAccounts = storageManagementClient.StorageAccounts;

                //await ResourceGroupHelper.CreateOrUpdateResourceGroup(rgName, region);

                // Create a storage account
                //Utilities.Log("Creating a Storage Account...");

                var StorageAccountCreateParameters = new StorageAccountCreateParameters(new Sku(SkuName.StandardLRS), Kind.StorageV2, region);

                var rawResult = await storageAccounts.StartCreateAsync("rgroup1", storageAccountName, StorageAccountCreateParameters);
                var storageAccount = (await rawResult.WaitForCompletionAsync()).Value;

                System.Console.WriteLine("Created Storage Account",storageAccount);
            }

            
            [Newtonsoft.Json.JsonProperty(PropertyName="state")]
            public Nullable<Microsoft.Azure.Management.Subscription.Models.SubscriptionState> State { get; }


            public Nullable<Microsoft.Azure.Management.Subscription.Models.SubscriptionState> RunSample2(){
                var credential = new ClientSecretCredential("c22265e7-900b-49c0-ac66-cf43cbb73b9f", "29b80fb6-a004-4343-8052-dc632e62a3d0", "xvzNSv.o3Yf5cZyDdJprkg1Pycv-zbm5~.");

                VisualStudioCredentialOptions visualStudioCredentialOptions = new VisualStudioCredentialOptions{ TenantId = tenant.TenantId };
                VisualStudioCredential tokenCredential1 = new VisualStudioCredential(visualStudioCredentialOptions);
                TokenRequestContext requestContext1 = new TokenRequestContext(new string[] { "https://management.azure.com" });
                CancellationTokenSource cts1 = new CancellationTokenSource();
                var accessToken1 = tokenCredential1.GetToken(requestContext, cts1.Token);
                ServiceClientCredentials serviceClientCredentials1 = new TokenCredentials(accessToken1.Token);
                SubscriptionClient SubscriptionClient1 = new SubscriptionClient(serviceClientCredentials1);
                var subs = SubscriptionClient1.Subscriptions.List();
                

                Console.WriteLine($"State2: {State}");
                return(
                State
                );
            }

            public static async Task GetSubscriptionInfo(ClientSecretCredential credential){
                string subscriptionId = "2c308107-f204-43da-8bcb-f922f5148d9f";
 
            }

        private readonly ILogger<AzureDataController> _logger;

        public AzureDataController(ILogger<AzureDataController> logger)
        {
            _logger = logger;
        }
        public int index = 2;


        [HttpGet]
        
        public async Task AzureData()
        {
            //await RunSample();           
            RunSample2();
        }
    }
}
