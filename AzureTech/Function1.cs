using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureTech
{
    public static class Function1
    {
        [FunctionName("AzureTechLive")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {


            return new OkObjectResult(

                new[] {
                new
                {
                    Id = 1,
                    BookName = "Clean Coder",
                    Price = 39.99D,
                    Author = "Robert C. Martin"
                },
                new
                {
                    Id = 2,
                    BookName = "Clean Coder",
                    Price = 39.99D,
                    Author = "Robert C. Martin"
                }, 
                }
                );
        }
    }
}
