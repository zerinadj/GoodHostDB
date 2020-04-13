namespace GoodHostDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

 
    public class Device
    {
     
        [Key]
        public int IdDevice { get; set; }

        [Required]
        [StringLength(50)]
        public string DeviceName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

   
    }
}
