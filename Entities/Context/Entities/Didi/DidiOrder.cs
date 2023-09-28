﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Didi
{
    public class DidiOrder
    {
        [Key]
        public long order_id { get; set; }
        public int status { get; set; }
        public int shop_accept_status { get; set; }
        public int before_status { get; set; }
        public int order_index { get; set; }
        public string remark { get; set; }
        public int city_id { get; set; }
        public string country { get; set; }
        public string timezone { get; set; }
        public int pay_type { get; set; }
        public int delivery_type { get; set; }
        public int expected_cook_eta { get; set; }
        public int expected_arrived_eta { get; set; }
        public int create_time { get; set; }
        public int pay_time { get; set; }
        public int complete_time { get; set; }
        public int cancel_time { get; set; }
        public int shop_confirm_time { get; set; }
        public PriceInfo price { get; set; }
        public ShopInfo shop { get; set; }
        public ReceiveAddress receive_address { get; set; }
        public List<OrderItemInfo> order_items { get; set; }
        public List<Promotion> promotions { get; set; }
        public List<Shopper> shopper_info { get; set; }
    }
}
