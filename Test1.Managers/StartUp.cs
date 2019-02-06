using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Test1.DataAccess.Contexts;
using Test1.Managers.Interfaces;

namespace Test1.Managers
{
    public class StartUp
    {

        public void ConfigureServices(IServiceCollection services, string connectionString)
        {
            var dataStart = new Test1.DataAccess.StartUp();
            dataStart.ConfigureServices(services, connectionString);
            services.AddTransient<ICountryManager, CountryManager>();
            services.AddTransient<IDomainModelContext, DomainModelPostgreSqlContext>();
        }
    }
}
