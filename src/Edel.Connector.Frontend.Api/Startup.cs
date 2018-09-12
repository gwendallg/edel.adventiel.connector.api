﻿using Autumn.Mvc;
using Autumn.Mvc.Data;
using Autumn.Mvc.Data.Configurations;
using Autumn.Mvc.Data.MongoDB;
using Autumn.Mvc.Data.Swagger;
using Edel.Connector.Frontend.Api.Controllers;
using Edel.Connector.Frontend.Api.Swagger;
using Edel.Connector.Models;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
// ReSharper disable All

namespace Edel.Connector.Frontend.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
    
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
                .AddInitialization(_configuration)
                .AddTransient<IServiceFactory, ServiceFactory>()
                .TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            var pack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register("EnumStringConvention", pack, t => true);
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
                .UseAuthentication()
                .UseMvc();
            
            ConnectorHelper.Initialize(app);
        }
    }
}