using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Autumn.Mvc.Data;
using Edel.Adventiel.Connector.Api.Models.Users;
using Edel.Adventiel.Connector.Entities;
using Edel.Adventiel.Connector.Services;
using Hangfire;
using Hangfire.Mongo;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
// ReSharper disable All

namespace Edel.Adventiel.Connector.Api
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

            // initialization de la base base de donnés
            ConnectorHelper.Initialize(serviceCollection.GetAutumnDataSettings(), database);

            // user service ioc registration
            serviceCollection.AddScoped<IUserService, UserCollectionService>();
            JobStorage.Current = new MongoStorage(connectionString, databaseName);
            RecurringJob.AddOrUpdate(
                "Edel Collector",
                () => Job(connectionString, databaseName),
                Cron.Minutely
            );

            return serviceCollection;
        }

        public static void Job(string connectionString, string database)
        {
            var mongoClient = new MongoClient(connectionString);
            var service = new CollectorService(mongoClient.GetDatabase(database));
            var task = service.CollectAsync();
            task.Wait();
        }

        /// <summary>
        /// build mapper
        /// </summary>
        /// <returns></returns>
        private static IMapper BuildMapper()
        {
            // register Mapper,
            var baseMappings = new MapperConfigurationExpression();
            baseMappings.CreateMap<UserPostRequestModel, User>();
            baseMappings.CreateMap<UserPutRequestModel, User>();

            var mapperConfiguration = new MapperConfiguration(baseMappings);
            return new Mapper(mapperConfiguration);
        }

        private static void TryAddDepartmentsIfNotExist(IServiceCollection serviceCollection, IMongoDatabase database)
        {

        }

        private static void TryAddAdminIfNotExistUsers(IServiceCollection serviceCollection,IMongoDatabase database)
        {
            var service = new UserCollectionService(serviceCollection.GetAutumnDataSettings(), database);
            service.TryAddAdminIfNotExistUsers();
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
                            OnTokenValidated = async ctx => CheckAuthorizationAsync(ctx)
                        };
                    }
                );

            return serviceCollection;
        }



        private static async Task CheckAuthorizationAsync(TokenValidatedContext context)
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
        }
    }
}