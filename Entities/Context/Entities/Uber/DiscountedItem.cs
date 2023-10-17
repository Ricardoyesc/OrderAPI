using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class DiscountedItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string cart_item_id { get; set; }
        public virtual Money discount_amount { get; set; }
        public string external_item_discount_id { get; set; }
    }
}