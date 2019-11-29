using System;
using System.Threading.Tasks;
using Backend;
using HotChocolate.Subscriptions;
using TodoGraphQL.Data;

namespace TodoGraphQL.GraphQL
{
    public class Subscription
    {
        private readonly TodoRepository _todoRepository;

        public Subscription(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Todo> OnTodo(IEventMessage message)
        {
            var id = (Guid)message.Payload;
            return await _todoRepository.Get(id);
        }
    }
}
