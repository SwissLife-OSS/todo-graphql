using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class Todo
        : ITodo
    {
        public Todo(
            string id, 
            TodoStatus status, 
            string title)
        {
            Id = id;
            Status = status;
            Title = title;
        }

        public string Id { get; }

        public TodoStatus Status { get; }

        public string Title { get; }
    }
}
