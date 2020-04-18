using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Projekat_1.Models
{
    [Table("Rent")]
    public class Rent
    {

        [Key]
        public int IdRent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckOut { get; set; }


    }
}
