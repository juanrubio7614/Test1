using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Test1.Library.DataEntities;
using Test1.Managers.Interfaces;

namespace Test1.Api.ApplicationWeb.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CountryController : Controller
    {
        private ICountryManager _countryManager;
        public CountryController(ICountryManager countryManager)
        {
            _countryManager = countryManager;
        }
        // GET: api/Country
        [Route("GetAll")]
        [HttpGet]
        public ActionResult<List<Country>> GetAll()
        {
            return _countryManager.GetAll();// new string[] { "value1", "value2" };
        }

        // GET: api/Country/5
        [Route("Get/{id}")]
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Country
        [Route("Add")]
        [HttpPost]
        public void Add(Country country)
        {
            _countryManager.SaveNew(country);
        }

        // PUT: api/Country/5
        [Route("Update")]
        [HttpPut]
        public void Put(Country country)
        {
            _countryManager.Update(country);
        }

        // DELETE: api/ApiWithActions/5
        [Route("Delete")]
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
        }
    }
}
