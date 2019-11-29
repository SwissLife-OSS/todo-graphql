using HotChocolate.Types;
using TodoGraphQL.Data;

namespace TodoGraphQL.GraphQL
{
    public class TodoType
        : ObjectType<Todo>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Todo> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor
                .Field(x => x.Id)
                .Type<NonNullType<IdType>>();

            descriptor
                .Field(x => x.Title)
                .Type<NonNullType<StringType>>();

            descriptor
                .Field(x => x.Status)
                .Type<NonNullType<EnumType<TodoStatus>>>();
        }
    }
}
