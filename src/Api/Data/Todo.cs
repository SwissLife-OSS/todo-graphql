using System;

namespace TodoGraphQL.Data
{
    public class Todo
    {
        public Todo(Guid id, string title, TodoStatus status)
        {
            Id = id;
            Title = title;
            Status = status;
        }

        public Guid Id { get; }
        public string Title { get; }
        public TodoStatus Status { get; }
    }

    public enum TodoStatus
    {
        Active,
        Completed
    }
}
