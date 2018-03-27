using System.Linq;
using System.Text;
using Autumn.Mvc.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Edel.Adventiel.Connector.Api
{
    public static class IServiceCollectionExtensions
    {
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
                            OnTokenValidated = async ctx =>
                            {

                                var claimType = ctx.Request.Path.Value.TrimStart('/').Replace("/", "_");

                                var pathItem = claimType.Split('_');
                                if (pathItem.Length >= 3)
                                {
                                    claimType = string.Format("{0}_{1}", pathItem[0], pathItem[1]);
                                }
                                var claims = ctx
                                    .Principal
                                    .Claims
                                    .SingleOrDefault(c => c.Type == claimType);

                                if (claims == null)
                                {
                                    ctx.Fail("access not authorized");
                                }
                                else
                                {
                                    switch (ctx.Request.Method)
                                    {
                                        case "GET" when !claims.Value.Contains("read"):
                                            ctx.Fail("read not authorized");
                                            break;
                                        case "POST" when !claims.Value.Contains("create"):
                                            ctx.Fail("create not authorized");
                                            break;
                                        case "PUT" when !claims.Value.Contains("update"):
                                            ctx.Fail("update not authorized");
                                            break;
                                        case "DELETE" when !claims.Value.Contains("delete"):
                                            ctx.Fail("delete not authorized");
                                            break;
                                    }
                                }
                            }
                        };
                    }
                );

            return serviceCollection;
        }
    }
}