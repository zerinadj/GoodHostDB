namespace GoodHostDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Review")]
    public class Review
    {
        [Key]
        public int IdReview { get; set; }

        public int OfferId { get; set; }

        public int UserRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int RatingId { get; set; }

        [Required]
        [StringLength(50)]
        public string Comment { get; set; }

        public virtual Offer Offer { get; set; }

        public virtual Rating Rating { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
