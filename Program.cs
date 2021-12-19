using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;

namespace azuredeploy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            try
            {
                // Authenticate
                //var credential = new DefaultAzureCredential();
                var credential = new ClientSecretCredential("c22265e7-900b-49c0-ac66-cf43cbb73b9f", "29b80fb6-a004-4343-8052-dc632e62a3d0", "xvzNSv.o3Yf5cZyDdJprkg1Pycv-zbm5~.");

                
                //await RunSample(credential);
            }
            catch (Exception ex)
            {
            
                Console.WriteLine(ex);
                //Utilities.Log(ex);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
