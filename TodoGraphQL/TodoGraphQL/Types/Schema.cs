using System;
using HotChocolate;

namespace TodoGraphQL.Types
{
    public class Schema
    {
        public static ISchema Create(IServiceProvider serviceProvider) =>
            SchemaBuilder.New()
                .AddServices(serviceProvider)
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .AddSubscriptionType<SubscriptionType>()
                .AddType<TodoInputType>()
                .AddType<TodoPayload>()
                .Create();
    }
}
