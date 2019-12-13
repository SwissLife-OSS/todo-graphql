using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface ITodoAppClient
    {
        Task<IOperationResult<IGet>> GetAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGet>> GetAsync(
            GetOperation operation,
            CancellationToken cancellationToken = default);
    }
}
