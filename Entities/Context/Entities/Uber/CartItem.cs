using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string item_id { get; set; }
        public string cart_item_id { get; set; }
        public string title { get; set; }
        public string external_data { get; set; }

        public string customer_id { get; set; }
        public virtual Quantity quantity { get; set; }
        public virtual Quantity default_quantity { get; set; }

        public virtual CustomerRequests customer_requests { get; set; }

        public virtual List<SelectedModifierGroup> selected_modifier_groups { get; set; }
        public string picture_url { get; set; }
    }
}