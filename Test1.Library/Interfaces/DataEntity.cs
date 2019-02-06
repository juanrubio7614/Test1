using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Test1.Library.Interfaces
{
   public abstract class DataEntity:IDataEntity
    {
        [Key]
        [Column("Id")]
        public int? Id { get; set; }
    }
}
