using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoGraphQL.Data;

namespace Backend
{
    public class TodoRepository
    {
        private readonly List<Todo> _items =
            new List<Todo>();

        public Task<IEnumerable<Todo>> Get()
        {
            return Task.FromResult(_items.AsEnumerable());
        }

        public Task<Todo> Get(Guid id)
        {
            return Task.FromResult(_items.FirstOrDefault(x => x.Id == id));
        }

        public Task Add(Todo todo)
        {
            _items.Add(todo);
            return Task.CompletedTask;
        }
    }
}
