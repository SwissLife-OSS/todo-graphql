using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface ITodo
    {
        string Id { get; }

        TodoStatus Status { get; }

        string Title { get; }
    }
}
