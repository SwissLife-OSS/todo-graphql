using Backend;

namespace TodoGraphQL.GraphQL
{
    public class Subscription
    {
        private readonly TodoRepository _todoRepository;

        public Subscription(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
    }
}
