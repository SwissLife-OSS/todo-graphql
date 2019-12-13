using System;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Subscriptions;
using TodoGraphQL.Data;

namespace TodoGraphQL.Types
{
    public class Mutation
    {
        private readonly TodoRepository _todoRepository;

        public Mutation(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<Todo> Add(
            TodoInput input,
            [Service] IEventSender eventSender)
        {
            var todo = new Todo(Guid.NewGuid(), input.Title, input.Status);
            await _todoRepository.Add(todo);
            await eventSender.SendAsync(new OnTodoAdded(todo));
            return todo;
        }
    }
}
