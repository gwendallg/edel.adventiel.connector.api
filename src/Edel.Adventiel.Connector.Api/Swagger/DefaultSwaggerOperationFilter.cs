using System.Reflection;
using Autumn.Mvc.Configurations;
using Autumn.Mvc.Data;
using Autumn.Mvc.Data.Controllers;
using Autumn.Mvc.Data.Swagger;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Edel.Adventiel.Connector.Api.Swagger
{
    public class DefaultSwaggerOperationFilter : SwaggerOperationFilter
    {
        public override void Apply(Operation operation, OperationFilterContext context)
        {
            base.Apply(operation, context);

            if (operation.Parameters == null) return;
            if (!(context.ApiDescription.ActionDescriptor is ControllerActionDescriptor actionDescriptor)) return;


            var authorizeAttribute = actionDescriptor.ControllerTypeInfo.GetCustomAttribute(typeof(AuthorizeAttribute));
            if (authorizeAttribute == null) return;
            var parameter = new NonBodyParameter()
            {
                In = "header",
                Type = "string",
                Name = "Authorization",
                Description = "Bearer token"
            };
            operation.Parameters.Add(parameter);
        }

        public DefaultSwaggerOperationFilter(AutumnSettings settings) : base(settings)
        {
        }
    }
}