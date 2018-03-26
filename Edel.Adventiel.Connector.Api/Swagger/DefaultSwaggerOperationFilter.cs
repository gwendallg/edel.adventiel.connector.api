using Autumn.Mvc.Configurations;
using Autumn.Mvc.Data;
using Autumn.Mvc.Data.Controllers;
using Autumn.Mvc.Data.Swagger;
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
            if (!actionDescriptor.ControllerTypeInfo.IsGenericType) return;
            if (actionDescriptor.ControllerTypeInfo.GetGenericTypeDefinition() !=typeof(RepositoryControllerAsync<,,,>))
            {
                if (!typeof(RepositoryControllerAsync<,,,>).IsSubclassOfRawGeneric(actionDescriptor.ControllerTypeInfo))
                    return;
            }

            var parameter = new NonBodyParameter()
            {
                In = "header",
                Type = "string",
                Name = "Authorization",
                Description = "Beared token"
            };
            operation.Parameters.Add(parameter);

        }

        public DefaultSwaggerOperationFilter(AutumnSettings settings) : base(settings)
        {
        }
    }
}