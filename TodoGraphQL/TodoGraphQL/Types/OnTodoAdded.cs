using HotChocolate.Subscriptions;
using TodoGraphQL.Data;

namespace TodoGraphQL.Types
{
    public class OnTodoAdded
        : EventMessage
    {
        public OnTodoAdded(Todo todo)
            : base(new EventDescription("onTodo"), todo)
        {
        }
    }
}
