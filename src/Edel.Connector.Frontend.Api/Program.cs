﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Edel.Connector.Frontend.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}