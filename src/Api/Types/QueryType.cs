using HotChocolate.Types;

namespace TodoGraphQL.Types
{
    public class QueryType
        : ObjectType<Query>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .BindFieldsExplicitly();

            descriptor
                .Field(t => t.Get())
                .Type<NonNullType<ListType<NonNullType<TodoPayload>>>>();
        }
    }
}
