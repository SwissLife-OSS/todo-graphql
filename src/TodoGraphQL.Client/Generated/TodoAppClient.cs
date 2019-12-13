using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace SwissLife.OSS.TodoGraphQL.Client
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class TodoAppClient
        : ITodoAppClient
    {
        private const string _clientName = "TodoAppClient";

        private readonly IOperationExecutor _executor;

        public TodoAppClient(IOperationExecutorPool executorPool)
        {
            _executor = executorPool.CreateExecutor(_clientName);
        }

        public Task<IOperationResult<IGet>> GetAsync(
            CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetOperation(),
                cancellationToken);
        }

        public Task<IOperationResult<IGet>> GetAsync(
            GetOperation operation,
            CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
