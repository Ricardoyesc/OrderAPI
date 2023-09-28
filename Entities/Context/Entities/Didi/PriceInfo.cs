using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Didi
{
    public class PriceInfo
    {
        public int id { get; set; }
        public int order_price { get; set; }
        public int shop_paid_money { get; set; }
        public int refund_price { get; set; }
        public int items_discount { get; set; }
        public int delivery_discount { get; set; }

    }


}
