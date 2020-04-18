using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Projekat_1.Models
{
    [Table("UserRole")]
    public class UserRole
    {


        [Key]
        public int IdURole { get; set; }

        public int IdUser { get; set; }

        public int IdRole { get; set; }

        public Role Role { get; set; }

        public User User { get; set; }
    }
}
