using System.Collections.Generic;
using System.Threading.Tasks;
using TodoGraphQL.Data;

namespace TodoGraphQL.Types
{
    public class Query
    {
        private readonly TodoRepository _todoRepository;

        public Query(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public async Task<IEnumerable<Todo>> Get()
        {
            return await _todoRepository.Get();
        }
    }
}
