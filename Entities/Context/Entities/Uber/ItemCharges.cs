using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class ItemCharges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual Money Total { get; set; }
        public virtual Money SubtotalIncludingPromos { get; set; }

        public virtual PriceBreakdown PriceBreakdown { get; set; }
        public virtual UberDiscount Discount { get; set; }
        public virtual Money Unit { get; set; }
    }

}