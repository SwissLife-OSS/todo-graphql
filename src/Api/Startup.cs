using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Builder;
using HotChocolate.Subscriptions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoGraphQL.Data;
using Schema = TodoGraphQL.Types.Schema;

namespace TodoGraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInMemorySubscriptionProvider();
            services.AddSingleton<TodoRepository>();
            services.AddGraphQL(Schema.Create,
                new QueryExecutionOptions
                {
                    TracingPreference = TracingPreference.Always
                });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseWebSockets();
            app.UseGraphQL();
        }
    }
}
