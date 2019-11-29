using HotChocolate.Language;
using HotChocolate.Subscriptions;
using TodoGraphQL.Data;

namespace TodoGraphQL.GraphQL
{
    public class OnTodoAdded
        : EventMessage
    {
        public OnTodoAdded(Todo todo)
            : base(CreateEventDescription(todo), todo)
        {
        }

        private static EventDescription CreateEventDescription(Todo todo) =>
            new EventDescription("onTodo",
                new ArgumentNode("todo", new EnumValueNode(todo.Id.ToString("N"))));
    }
}
