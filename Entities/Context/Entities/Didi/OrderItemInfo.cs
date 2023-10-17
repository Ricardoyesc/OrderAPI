using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Didi
{
    public class OrderItemInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long order_item_id { get; set; }
        public string app_item_id { get; set; }
        public string name { get; set; }
        public int sku_price { get; set; }
        public int total_price { get; set; }
        public int amount { get; set; }
        public int submit_refund_amount { get; set; }
        public int real_price { get; set; }
        public int promo_type { get; set; }
        public virtual List<SubItem>? sub_item_list { get; set; }
        public virtual PromotionDetail? promotion_detail { get; set; }
    }


}
