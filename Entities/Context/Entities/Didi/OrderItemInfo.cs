namespace Entities.Context.Entities.Didi
{
    public class OrderItemInfo
    {
        public string app_item_id { get; set; }
        public string name { get; set; }
        public int sku_price { get; set; }
        public int total_price { get; set; }
        public int amount { get; set; }
        public int submit_refund_amount { get; set; }
        public List<SubItem> sub_item_list { get; set; }
        public int real_price { get; set; }
        public int promo_type { get; set; }
        public PromotionDetail promotion_detail { get; set; }
    }


}
