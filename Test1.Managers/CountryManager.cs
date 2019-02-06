using Test1.DataAccess.Interfaces;
using Test1.Library.DataEntities;
using Test1.Managers.Interfaces;

namespace Test1.Managers
{
    public class CountryManager : BaseManager<Country>, ICountryManager
    {
         private readonly  ICountryRepository _countryRepository;

               
        public CountryManager(ICountryRepository countryRepository):base(countryRepository)
        {
            _countryRepository = countryRepository;
        }
        
    }
}
