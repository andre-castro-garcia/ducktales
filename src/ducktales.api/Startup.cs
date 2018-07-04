using System.Diagnostics.CodeAnalysis;
using ducktales.data.Interfaces;
using ducktales.data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global

namespace ducktales.api {
    
    [ExcludeFromCodeCoverage]
    public class Startup {

        public void ConfigureServices(IServiceCollection services) {
            services.AddTransient<IUncleScroogeRepository, UncleScroogeRepository>();
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) 
                app.UseDeveloperExceptionPage();
            app.UseMvc();
        }
    }
}