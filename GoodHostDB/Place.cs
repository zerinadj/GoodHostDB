namespace GoodHostDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public class Place
    {
        
        [Key]
        public int IdPlace { get; set; }

        public int AddressId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? Price { get; set; }

        public bool? Availability { get; set; }

        public int? Rooms { get; set; }

        public int? MaxOfGuests { get; set; }

        public virtual Address Address { get; set; }

        
    }
}
