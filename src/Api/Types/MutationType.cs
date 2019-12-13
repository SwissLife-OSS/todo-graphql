using HotChocolate.Types;

namespace TodoGraphQL.Types
{
    public class MutationType
        : ObjectType<Mutation>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor
                .BindFieldsExplicitly();

            descriptor
                .Field(t => t.Add(default, default))
                .Type<NonNullType<TodoPayload>>()
                .Argument("input", a => a.Type<NonNullType<TodoInputType>>());
        }
    }
}
