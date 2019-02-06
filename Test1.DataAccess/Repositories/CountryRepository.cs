using Test1.DataAccess.Contexts;
using Test1.DataAccess.Interfaces;
using Test1.Library.DataEntities;
namespace Test1.DataAccess.Repositories
{
    public class CountryRepository:Repository<Country>,ICountryRepository
    {
        public CountryRepository(DomainModelPostgreSqlContext context) : base(context)
        {
        }
    }
}
