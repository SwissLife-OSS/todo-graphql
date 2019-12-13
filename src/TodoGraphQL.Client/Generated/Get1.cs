using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class Get1
        : IGet
    {
        public Get1(
            IReadOnlyList<ITodo> get)
        {
            Get = get;
        }

        public IReadOnlyList<ITodo> Get { get; }
    }
}
