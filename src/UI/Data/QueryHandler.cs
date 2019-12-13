using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StrawberryShake;
using SwissLife.OSS.TodoGraphQL.Client;

namespace TodoGraphQL.UI
{
    public class QueryHandler
    {

        private readonly ITodoAppClient _todoAppClient;

        public QueryHandler(ITodoAppClient todoAppClient)
        {
            _todoAppClient = todoAppClient ?? throw new ArgumentNullException(nameof(todoAppClient));
        }

        public async Task<IEnumerable<TodoItem>> GetTodoItems()
        {
            IOperationResult<IGet> response = await _todoAppClient.GetAsync();
            response.EnsureNoErrors();
            return ConvertToTodoItems(response.Data.Get);
        }

        private IEnumerable<TodoItem> ConvertToTodoItems(IEnumerable<ITodo> items)
        {
            foreach (var item in items)
            {
                yield return item.MapToTodoItem();
            }
        }
    }
}
