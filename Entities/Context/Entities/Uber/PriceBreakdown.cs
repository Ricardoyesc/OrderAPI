using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class PriceBreakdown
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? cart_item_id { get; set; }

        public virtual Quantity quantity { get; set; }
        public virtual Money? total { get; set; }
        public virtual UberDiscount? discount { get; set; }
        public virtual Money? unit { get; set; }
        public bool is_tax_inclusive { get; set; }
    }
}