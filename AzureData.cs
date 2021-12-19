using System;
using System.Threading.Tasks;

using Azure.Identity;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;

namespace azuredeploy
{
    public class AzureData
    {

            public string subscriptionId {get;set;}
            public   string storageAccountName {get;set;}
            public   string region {get;set;}
    }  
}