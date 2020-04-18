using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekat_1.Models
{
    [Table("Offer")]
    public class Offer
    {


        [Key]
        public int IdOffer { get; set; }

        public int PlaceId { get; set; }

        public int RentId { get; set; }

        public int UserRoleId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual Place Place { get; set; }

        public virtual Rent Rent { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}