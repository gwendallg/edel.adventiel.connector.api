using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Edel.Connector.Api.HealthChecks;
using Edel.Connector.Api.Mappings.Claims;
using Edel.Connector.Api.Models;
using Edel.Connector.Api.Models.Subscriptions;
using Edel.Connector.Api.Models.Users;
using Edel.Connector.Api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace Edel.Connector.Api
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="connectionString">chaine de connnection</param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public static IServiceCollection AddInitialization(this IServiceCollection serviceCollection,
            string connectionString, string databaseName)
        {
            // mongo Client ioc registration

            var mongoClient = new MongoClient(connectionString);
            serviceCollection.AddSingleton<IMongoClient>(mongoClient);

            // mongo Database ioc registration
            serviceCollection.AddScoped(s => s.GetService<IMongoClient>().GetDatabase(databaseName));

            // mapper ioc registration
            serviceCollection.AddSingleton(BuildMapper());

            // user service ioc registration
            serviceCollection.AddScoped<IUserService, UserService>();
            serviceCollection.AddScoped<ISubscriptionService, SubscriptionService>();
            serviceCollection.AddSingleton<IClaimsService, ClaimsService>();
      
            // healthcheck
            serviceCollection.AddHealthChecks(checks =>
            {
                // check user collection
                checks.AddMongoCheck(connectionString, databaseName, new[] {"user"});
            });

            var pack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
            };

            ConventionRegistry.Register("EnumStringConvention", pack, t => true);
 
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
            baseMappings.AddProfile(new ClaimProfile());

            var mapperConfiguration = new MapperConfiguration(baseMappings);
            return new Mapper(mapperConfiguration);
        }


        public static IServiceCollection AddSecurity(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            // Get options from app settings

            var validIssuer = configuration.GetValue<string>("JWT_VALID_ISSUER");
            var validAudience = configuration.GetValue<string>("JWT_VALID_AUDIENCE");
            var securityKey = configuration.GetValue<string>("JWT_SECURITY_KEY");

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
                            ValidIssuer = validIssuer,
                            ValidAudience = validAudience,
                            IssuerSigningKey =
                                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey))
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
            var path = context.Request.Path.Value;
            if(path.StartsWith("/v1/claim")) return Task.CompletedTask;
            
            var claimType = context.Request.Path.Value.TrimStart('/');
            var pathItem = claimType.Split('/');
            if (pathItem.Length >= 3)
            {
                claimType = string.Format("{0}/{1}", pathItem[0], pathItem[1]);
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
                    case "GET" when !claim.Value.Contains(ScopeType.Read.ToString().ToLowerInvariant()):
                        context.Fail("read not authorized");
                        break;
                    case "POST" when !claim.Value.Contains(ScopeType.Create.ToString().ToLowerInvariant()):
                        context.Fail("create not authorized");
                        break;
                    case "PUT" when !claim.Value.Contains(ScopeType.Update.ToString().ToLowerInvariant()):
                        context.Fail("update not authorized");
                        break;
                    case "DELETE" when !claim.Value.Contains(ScopeType.Delete.ToString().ToLowerInvariant()):
                        context.Fail("delete not authorized");
                        break;
                }
            }

            return Task.CompletedTask;
        }
    }
}