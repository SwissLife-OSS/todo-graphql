using System.Threading.Tasks;
using Backend;
using HotChocolate;
using HotChocolate.Subscriptions;
using TodoGraphQL.Data;

namespace TodoGraphQL.GraphQL
{
    public class Mutation
    {
        private readonly TodoRepository _todoRepository;

        public Mutation(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Todo> Add(
            Todo todo,
            [Service] IEventSender eventSender)
        {
            await _todoRepository.Add(todo);
            await eventSender.SendAsync(new OnTodoAdded(todo));
            return todo;
        }
    }
}
