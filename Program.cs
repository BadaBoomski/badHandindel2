using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using quickstartcore;
// ADDED ACCORDING TO MS TUTORIAL
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace quickstartcore
{
    public class Program
    {
        private DocumentClient client;

        public static void Main(string[] args)
        {

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
