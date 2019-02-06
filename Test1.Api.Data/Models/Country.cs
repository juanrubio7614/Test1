using System.ComponentModel.DataAnnotations.Schema;

namespace Test1.Api.Data.Models
{
    [Table("Country")]
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryIsoCode { get; set; }
    }
}
