using SwissLife.OSS.TodoGraphQL.Client;

namespace TodoGraphQL.UI
{
    public static class TodoExtensions
    {
        public static TodoItem MapToTodoItem(this ITodo todo)
        {
            return new TodoItem
            {
                Id = todo.Id,
                Title = todo.Title,
                Status = todo.Status
            };
        }
    }
}
