using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class DiscountedItem
    {
        [Key]
        public string? external_id { get; set; }
        public string? discounted_quantity { get; set; }
        public string? discount_amount_applied { get; set; }
    }
}