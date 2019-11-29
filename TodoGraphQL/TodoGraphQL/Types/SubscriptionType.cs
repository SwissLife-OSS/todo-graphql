using HotChocolate.Types;

namespace TodoGraphQL.Types
{
    public class SubscriptionType
        : ObjectType<Subscription>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Subscription> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor
                .Field(t => t.OnTodo(default))
                .Type<NonNullType<TodoPayload>>();
        }
    }
}
