using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Test1.DataAccess.Contexts;
using Test1.Library.DataEntities;

namespace Test1.Api.ApplicationWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    
    [ApiController]
    public class ValuesController : Controller
    {
     //   DomainModelPostgreSqlContext db = new DomainModelPostgreSqlContext();
        // GET api/values
        [HttpGet]
        //public ActionResult<List<Country>> Get()
        //{
        //    return
        //    //return db.Countries.ToList();
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(Country country)
        {
            //db.Countries.Add(country);

            ////db.Countries.Add(new Country() { CountryName = "ARGENTINA", CountryIsoCode = "ARG" });
            //db.SaveChanges();
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            //Country country = db.Countries.ToList().Where(x => x.Id == id).FirstOrDefault();
            //if (country != null)
            //{
            //    country.CountryName = "ARGENTINA";
            //    country.CountryIsoCode = "ARG";
            //    db.SaveChanges();
            //    //db.Countries.Add(new Country() { Id = 2, CountryName = "ARGENTINA", CountryIsoCode = "ARG" });
            //}
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
