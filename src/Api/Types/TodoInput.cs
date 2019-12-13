using TodoGraphQL.Data;

namespace TodoGraphQL.Types
{
    public class TodoInput
    {
        public string Title { get; set; }
        public TodoStatus Status { get; set; }
    }
}
