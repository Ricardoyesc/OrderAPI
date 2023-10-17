using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Discounted
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string cart_item_id { get; set; }
        public string price_type { get; set; }

        public virtual Quantity quantity { get; set; }

        public virtual Money total { get; set; }

        public virtual UberDiscount discount { get; set; }
    }
}