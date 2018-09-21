using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace OAuth2._0_Demo.App_Start
{
    public class AuthorizationHeaderParameterOperationFilter : IOperationFilter
    {
        public AuthorizationHeaderParameterOperationFilter()
        {
        }

        public void Apply(Operation operation, SchemaRegistry context, ApiDescription apiDescription)
        {
            if (operation.parameters == null) operation.parameters = new List<Parameter>();
            operation.parameters.Add(new Parameter
            {
                name = "Authorization",
                @in = "header",
                description = "access token",
                required = true,
                type = "string"
            });
        }
    }
}