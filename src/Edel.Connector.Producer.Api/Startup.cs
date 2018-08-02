using Edel.Connector.Dto.HealthChecks;
using Edel.Connector.Frontend.Api;
using Hangfire;
using Hangfire.Mongo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Edel.Connector.Producer.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            var connectionString = $"{Configuration[key: "ConnectionStrings:0:ConnectionString"]}";
            var databaseName = $"{Configuration[key: "ConnectionStrings:0:Database"]}";

            var mongoClient = new MongoClient(connectionString);
            serviceCollection.AddSingleton<IMongoClient>(mongoClient);

            // mongo Database ioc registration
            serviceCollection.AddScoped(s => s.GetService<IMongoClient>().GetDatabase(databaseName));

            // healthcheck
            serviceCollection.AddHealthChecks(checks =>
            {
                // check user collection
                checks.AddMongoCheck(connectionString, databaseName, new[] {"user"});

                var bootstrapServers = $"{Configuration["Kafka:BootstrapServers"]}";
                var topic = $"{Configuration["Kafka:Topic"]}";

                checks.AddKafkaCheck(bootstrapServers, "health-check");
            });
            
            serviceCollection
                .AddHangfire(c => { c.UseMongoStorage(connectionString, databaseName); })
                .AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHangfireServer()
                .UseHangfireDashboard()
                .UseEdel()
                .UseMvc();
        }
    }
}