using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoGraphQL.Data;

namespace Backend
{
    public class TodoService
    {
        public IEnumerable<Todo> GetAllAsync()
        {
            return Enumerable.Empty<Todo>();
        }

        public Task AddAsync()
        {
            return Task.CompletedTask;
        }
    }
}
