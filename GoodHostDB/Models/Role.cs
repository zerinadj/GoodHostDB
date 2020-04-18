using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Projekat_1.Models
{
    [Table("Role")]
    public class Role
    {

        [Key]
        public int IdRole { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Activity { get; set; }

    }
}
