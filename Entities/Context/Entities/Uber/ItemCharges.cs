using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class ItemCharges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Money? total { get; set; }
        public virtual Money? subtotal_including_promos { get; set; }
        public virtual PriceBreakdown? price_breakdown { get; set; }
        public virtual UberDiscount? discount { get; set; }
        public virtual Money? unit { get; set; }
    }
}