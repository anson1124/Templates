﻿namespace ApiTemplate.ViewModelSchemaFilters
{
    using ApiTemplate.ViewModels;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;

    public class CarSchemaFilter : ISchemaFilter
    {
        public void Apply(Schema model, SchemaFilterContext context)
        {
            model.Default = new Car()
            {
                CarId = 1,
                Cylinders = 6,
                Make = "Honda",
                Model = "Civic"
            };
        }
    }
}
