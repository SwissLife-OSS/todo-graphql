using System;
using HotChocolate;

namespace TodoGraphQL.GraphQL
{
    public class Schema
    {
        public static ISchema Create(IServiceProvider serviceProvider) =>
            SchemaBuilder.New()
                .AddServices(serviceProvider)
                .AddType<TodoType>()
                .Create();
    }
}
