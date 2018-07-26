using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Autumn.Mvc.Data;
using Edel.Connector.Entities;
using Edel.Connector.Frontend.Api.Models.Subscriptions;
using Edel.Connector.Frontend.Api.Models.Users;
using Edel.Connector.Mappings.Breeders;
using Edel.Connector.Mappings.Cattles;
using Edel.Connector.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
// ReSharper disable All

namespace Edel.Connector.Frontend.Api
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddInitialization(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            var connectionString = $"{configuration["ConnectionStrings:0:ConnectionString"]}";
            var databaseName = $"{configuration["ConnectionStrings:0:Database"]}";
            // mongo Client ioc registration

            var mongoClient = new MongoClient(connectionString);
            serviceCollection.AddSingleton<IMongoClient>(mongoClient);

            // mongo Database ioc registration
            serviceCollection.AddScoped(s => s.GetService<IMongoClient>().GetDatabase(databaseName));

            // mapper ioc registration
            serviceCollection.AddSingleton<IMapper>(BuildMapper());

            var database = new
                    MongoClient($"{configuration["ConnectionStrings:0:ConnectionString"]}")
                .GetDatabase($"{configuration["ConnectionStrings:0:Database"]}");


            // user service ioc registration
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<ISubscriptionService, SubscriptionService>();

            // initialization de la base base de donnés
            ConnectorHelper.Initialize(serviceCollection.GetAutumnDataSettings(), database);

            return serviceCollection;
        }

        /// <summary>
        /// build mapper
        /// </summary>
        /// <returns></returns>
        private static IMapper BuildMapper()
        {
            // register Mapper,
            var baseMappings = new MapperConfigurationExpression();
            baseMappings
                .CreateMap<UserPostRequestModel, User>();
            baseMappings
                .CreateMap<UserPutRequestModel, User>();
            baseMappings
                .CreateMap<SubscriptionPostRequestModel, Subscription>();
            baseMappings
                .CreateMap<SubscriptionPutRequestModel, Subscription>();

            var mapperConfiguration = new MapperConfiguration(baseMappings);
            return new Mapper(mapperConfiguration);
        }

        public static IServiceCollection AddSecurity(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            // Get options from app settings


            serviceCollection
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                    {
                        options.TokenValidationParameters = new TokenValidationParameters()
                        {
                            ValidateIssuer = true,
                            ValidateAudience = true,
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = $"{configuration["Jwt:ValidIssuer"]}",
                            ValidAudience = $"{configuration["Jwt:ValidAudience"]}",
                            IssuerSigningKey =
                                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SecurityKey"]))
                        };

                        options.Events = new JwtBearerEvents()
                        {
                            OnTokenValidated = async ctx => await CheckAuthorizationAsync(ctx)
                        };
                    }
                );

            return serviceCollection;
        }



        private static Task CheckAuthorizationAsync(TokenValidatedContext context)
        {
            var claimType = context.Request.Path.Value.TrimStart('/').Replace("/", "_");
            var pathItem = claimType.Split('_');
            if (pathItem.Length >= 3)
            {
                claimType = string.Format("{0}_{1}", pathItem[0], pathItem[1]);
            }

            claimType += ":";

            var claim = context
                .Principal
                .Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .SingleOrDefault(c => c.Value.StartsWith(claimType));

            if (claim == null)
            {
                context.Fail("access not authorized");
            }
            else
            {
                switch (context.Request.Method)
                {
                    case "GET" when !claim.Value.Contains(ScopeType.Read.ToString()):
                        context.Fail("read not authorized");
                        break;
                    case "POST" when !claim.Value.Contains(ScopeType.Create.ToString()):
                        context.Fail("create not authorized");
                        break;
                    case "PUT" when !claim.Value.Contains(ScopeType.Update.ToString()):
                        context.Fail("update not authorized");
                        break;
                    case "DELETE" when !claim.Value.Contains(ScopeType.Delete.ToString()):
                        context.Fail("delete not authorized");
                        break;
                }
            }

            return Task.CompletedTask;
        }
    }
}