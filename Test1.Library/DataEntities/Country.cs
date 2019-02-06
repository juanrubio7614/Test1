using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test1.Library.Interfaces;

namespace Test1.Library.DataEntities
{
    [Table("Country")]
    public class Country:DataEntity
    {             
     
        [Column("CountryName")]
        [DataType(DataType.Text)]
        [MaxLength(255)]
        [Required]
        public string CountryName { get; set; }

        [DataType(DataType.Text)]
        [MaxLength(3)]
        [Required]
        public string CountryIsoCode { get; set; }
    }
}
