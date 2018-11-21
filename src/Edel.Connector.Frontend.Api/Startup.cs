using System.Text;
using Autumn.Mvc;
using Autumn.Mvc.Data;
using Autumn.Mvc.Data.Configurations;
using Autumn.Mvc.Data.MongoDB;
using Autumn.Mvc.Data.Swagger;
using Edel.Connector.Api.Controllers;
using Edel.Connector.Api.Models;
using Edel.Connector.Api.Services;
using Edel.Connector.Api.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using Newtonsoft.Json.Serialization;
using Serilog;
using Swashbuckle.AspNetCore.Swagger;

namespace Edel.Connector.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(_configuration).CreateLogger();
        }

        private string BuildConnectionString()
        {
            var hosts = _configuration.GetValue<string>("DB_HOSTS");
            var userName = _configuration.GetValue<string>("DB_USER");
            var password = _configuration.GetValue<string>("DB_PASSWORD");
            var options = _configuration.GetValue<string>("DB_OPTIONS");
            var databaseName = _configuration.GetValue<string>("DB_NAME");

            var builder = new StringBuilder();
            builder.Append("mongodb://");
            if (!string.IsNullOrWhiteSpace(userName))
            {
                builder.Append(userName + ":");
                builder.Append(password + "@");
            }

            builder.Append(hosts);
            
            if (!string.IsNullOrWhiteSpace(options))
            {
                builder.Append("?" + options);
            }

            return builder.ToString();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = BuildConnectionString();
            var databaseName = _configuration.GetValue<string>("DB_NAME");
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
                        .NamingStrategy(new KebabCaseNamingStrategy())
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
                .AddMvc();

            services
                .AddInitialization(connectionString, databaseName)
                .AddTransient<IServiceFactory, ServiceFactory>()
                .TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IApplicationLifetime applicationLifetime)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddSerilog(); 

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
                .UseAuthentication()
                .UseMvc();
            
            ConnectorHelper.Initialize(app);
        }
    }
}