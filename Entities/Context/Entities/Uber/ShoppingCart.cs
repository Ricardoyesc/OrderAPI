using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class ShoppingCart
    {
        [Key]
        public string? id { get; set; }
        public virtual List<CartItem> items { get; set; }
        public virtual List<FulfillmentIssue> fulfillment_issues { get; set; }
        public string? special_instructions { get; set; }
        public bool include_single_use_items { get; set; }
        public virtual RestrictedItems restricted_items { get; set; }
    }
}