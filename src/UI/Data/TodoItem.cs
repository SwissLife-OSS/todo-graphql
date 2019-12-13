using SwissLife.OSS.TodoGraphQL.Client;

namespace TodoGraphQL.UI
{
    public class TodoItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TodoStatus Status { get; set; }
        public bool IsDone
        {
            get
            {
                return Status == TodoStatus.Completed;
            }
            set
            {
                if (value)
                {
                    Status = TodoStatus.Completed;
                }
                else
                {
                    Status = TodoStatus.Active;
                }
            }
        }
    }
}
