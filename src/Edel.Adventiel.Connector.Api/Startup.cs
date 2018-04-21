using Autumn.Mvc;
using Autumn.Mvc.Data;
using Autumn.Mvc.Data.MongoDB;
using Autumn.Mvc.Data.Swagger;
using Edel.Adventiel.Connector.Api.Controllers;
using Edel.Adventiel.Connector.Api.Swagger;
using Edel.Adventiel.Connector.Entities;
using Edel.Adventiel.Connector.Services;
using Hangfire;
using Hangfire.Mongo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Bson.Serialization.Conventions;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
// ReSharper disable All

namespace Edel.Adventiel.Connector.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private static IServiceFactory _serviceFactory;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = $"{_configuration[key: "ConnectionStrings:0:ConnectionString"]}";
            var databaseName = $"{_configuration[key: "ConnectionStrings:0:Database"]}";
            services
                .AddAutumn(config =>
                {
                    config
                        .PageSize(50)
                        .PageSizeFieldName("l")
                        .QueryFieldName("q")
                        .SortFieldName("s")
                        .PageNumberFieldName("o")
                        .NamingStrategy(new SnakeCaseNamingStrategy());
                })
                .AddAutumnData(config =>
                    config
                        .RepositoryControllerType(type: typeof(DefaultCrudPageableRepositortyController<,,,>))
                        .ApiVersion("v1")
                        .PluralizeController(false)
                        .EntityAssembly(typeof(User).Assembly)
                )
                .AddAutumnMongo(config =>
                    config
                        .ConnectionString(connectionString)
                        .Database(databaseName)
                        .Convention(new CamelCaseElementNameConvention())
                )
                .AddSecurity(_configuration)
                .AddSwaggerGen(c =>
                {

                    foreach (var version in services.GetAutumnDataSettings().ApiVersions)
                    {
                        c.SwaggerDoc(version, new Info {Title = "api", Version = version});
                    }

                    c.DocumentFilter<SwaggerDocumentFilter>();
                    c.OperationFilter<DefaultSwaggerOperationFilter>();
                })
                .AddHangfire(config
                    => config
                        .UseMongoStorage(connectionString,
                            databaseName))
                .AddMvc();

            services
                .AddInitialization(_configuration)
                .AddTransient<IServiceFactory,ServiceFactory>()
                .AddTransient<ICollectorService, CollectorService>()
                .TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            IApplicationLifetime applicationLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseSwagger()
                .UseSwaggerUI(c =>
                {
                    foreach (var version in app.GetAutumnDataSettings().ApiVersions)
                    {
                        c.SwaggerEndpoint(string.Format("/swagger/{0}/swagger.json", version),
                            string.Format("API {0}", version));
                    }
                })
                .UseHangfireDashboard()
                .UseHangfireServer()
                .UseAuthentication()
                .UseMvc();
            
            var connectionString = $"{_configuration[key: "ConnectionStrings:0:ConnectionString"]}";
            var databaseName = $"{_configuration[key: "ConnectionStrings:0:Database"]}";
            JobStorage.Current = new MongoStorage(connectionString, databaseName);

            applicationLifetime.ApplicationStarted.Register(() =>
            {
                _serviceFactory = app.ApplicationServices.GetService<IServiceFactory>();
                RecurringJob.AddOrUpdate(
                    "Edel Collector",
                    () => CollectData(),
                    Cron.Minutely
                );
            });
        }


        public void CollectData()
        {
            var collectorService = _serviceFactory.Get<ICollectorService>();
            var task = collectorService.CollectAsync("22014107");
            task.Wait();
        }
    }
}