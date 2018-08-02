using System.Reflection;
using Autumn.Mvc.Configurations;
using Autumn.Mvc.Data.Swagger;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Connector.Frontend.Api.Swagger
{
    public class DefaultSwaggerOperationFilter : SwaggerOperationFilter
    {
        public override void Apply(Operation operation, OperationFilterContext context)
        {
            if (!(context.ApiDescription.ActionDescriptor is ControllerActionDescriptor actionDescriptor)) return;
            base.Apply(operation, context);
            var authorizeAttribute = actionDescriptor.ControllerTypeInfo.GetCustomAttribute(typeof(AuthorizeAttribute));
            if (authorizeAttribute == null) return;
            var parameter = new NonBodyParameter()
            {
                In = "header",
                Type = "string",
                Name = "Authorization",
                Description = "Bearer token",
                Required = true
            };
            operation.Parameters.Add(parameter);
        }

        public DefaultSwaggerOperationFilter(AutumnSettings settings) : base(settings)
        {
        }
    }
}