namespace GoodHostDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Spec
    {

        [Key]
        public int IdSpecs { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Created { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Updated { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Amenities { get; set; }

        
    }
}
