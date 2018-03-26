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
                            ValidAudience = $"{configuration["Jwt:ValidAndience"]}",
                            IssuerSigningKey =
                                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SecurityKey"]))

                        };

                        options.Events = new JwtBearerEvents()
                        {
                            OnTokenValidated = async ctx =>
                            {
                                var path = ctx.Request.Path.Value.Split('/');
                                var claimType = path[2];
                                if (path.Length >= 4)
                                    claimType += "_" + path[3];
                                var claims = ctx.Principal.Claims.SingleOrDefault(c => c.Type == claimType);
                                if (claims == null)
                                {
                                    ctx.Fail("00");
                                }
                                else
                                {
                                    if (ctx.Request.Method =="GET" && !claims.Value.Contains("read"))
                                    {
                                        ctx.Fail("");
                                    }

                                    if ((ctx.Request.Method == "POST" || ctx.Request.Method=="PUT") && !claims.Value.Contains("write"))
                                    {
                                        ctx.Fail("");
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