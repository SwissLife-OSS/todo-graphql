using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoGraphQL.Data
{
    public class TodoRepository
    {
        private readonly List<Todo> _items =
            new List<Todo>();

        public Task<IEnumerable<Todo>> Get()
        {
            return Task.FromResult(_items.AsEnumerable());
        }

        public Task Add(Todo todo)
        {
            _items.Add(todo);
            return Task.CompletedTask;
        }
    }
}
