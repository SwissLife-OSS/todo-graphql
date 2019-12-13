using HotChocolate.Types;
using TodoGraphQL.Data;

namespace TodoGraphQL.Types
{
    public class TodoInputType
        : InputObjectType<TodoInput>
    {
        protected override void Configure(
            IInputObjectTypeDescriptor<TodoInput> descriptor)
        {
            descriptor
                .BindFieldsExplicitly();

            descriptor
                .Field(x => x.Title)
                .Type<NonNullType<StringType>>();

            descriptor
                .Field(x => x.Status)
                .Type<NonNullType<EnumType<TodoStatus>>>();
        }
    }
}
