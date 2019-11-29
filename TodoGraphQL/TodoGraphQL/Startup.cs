using Backend;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Builder;
using HotChocolate.Subscriptions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Schema = TodoGraphQL.GraphQL.Schema;

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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddInMemorySubscriptionProvider();
            services.AddSingleton<TodoRepository>();

            services.AddGraphQL(Schema.Create,
                new QueryExecutionOptions
                {
                    TracingPreference = TracingPreference.Always
                });
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
            });

            app.UseWebSockets();
            app.UseGraphQL();
        }
    }
}
