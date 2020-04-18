using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Projekat_1.Models
{
    [Table("Rating")]
    public class Rating
    {
        [Key]
        public int IdRating { get; set; }

        public int HostRate { get; set; }

        public int Communication { get; set; }

        public int Location { get; set; }

        public int Value { get; set; }

        public int Accuracy { get; set; }

        public int Cleanliness { get; set; }

    }
}