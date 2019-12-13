using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Squadron;

namespace TodoGraphQL
{
    public class AppResourceService : IHostedService
    {
        private readonly MongoResource _mongoResource;

        public AppResourceService(MongoResource mongoResource)
        {
            _mongoResource = mongoResource;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _mongoResource.InitializeAsync();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await _mongoResource.DisposeAsync();
        }
    }
}
