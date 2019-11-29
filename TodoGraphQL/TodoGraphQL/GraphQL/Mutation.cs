using System.Collections.Generic;
using System.Threading.Tasks;
using Backend;
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

        public async Task<Todo> Add(Todo todo)
        {
            return await _todoRepository.Add(todo);
        }
    }
}
