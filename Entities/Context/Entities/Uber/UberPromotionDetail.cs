using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class UberPromotionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string external_promotion_id { get; set; }
        public string type { get; set; }
        public string discount_value { get; set; }
        public string discount_percentage { get; set; }
        public int discount_delivery_fee_value { get; set; }

        public virtual List<DiscountedItem> discounted_items { get; set; }
    }
}