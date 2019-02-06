using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Test1.DataAccess.Contexts;
using Test1.DataAccess.Interfaces;
using Test1.DataAccess.Repositories;

namespace Test1.DataAccess
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DomainModelPostgreSqlContext>(opt =>
            opt.UseNpgsql(connectionString)

            );
            services.AddTransient<ICountryRepository, CountryRepository>();
        }
    }
}
