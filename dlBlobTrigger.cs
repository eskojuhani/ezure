using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class dlBlobTrigger
    {
        [FunctionName("dlBlobTrigger")]
        public void Run([BlobTrigger("test-samples-trigger/{name}", Connection = "esefuncgroup894d_STORAGE")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
