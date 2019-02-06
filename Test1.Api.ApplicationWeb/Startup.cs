using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test1.DataAccess.Contexts;
using Test1.DataAccess.Interfaces;
using Test1.DataAccess.Repositories;

namespace Test1.Api.ApplicationWeb
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;            
           
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var postgresqlConnectionString = Configuration.GetConnectionString("csTest1");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);           
            var managerStartup = new Test1.Managers.StartUp();
            managerStartup.ConfigureServices(services, postgresqlConnectionString);                           
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
