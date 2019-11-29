using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoGraphQL.Data;

namespace Backend
{
    public class TodoRepository
    {
        public Task<IEnumerable<Todo>> Get()
        {
            return Task.FromResult(Enumerable.Empty<Todo>());
        }

        public Task<Todo> Add(Todo todo)
        {
            return Task.FromResult(todo);
        }
    }
}
