using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace Edel.Connector.Api
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            var webHost = BuildWebHost(args);
            webHost.Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog()
                .UseHealthChecks("/health")
                .Build();
    }
}