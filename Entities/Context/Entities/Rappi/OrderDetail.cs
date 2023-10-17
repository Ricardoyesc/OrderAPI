using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context.Entities.Rappi
{
    public class OrderDetail
    {
        [Key]
        public string? order_id { get; set; }
        public int coooking_time { get; set; }
        public int min_cooking_time { get; set; }
        public int max_cooking_time { get; set; }
        public string? created_at { get; set; }
        public string? delivery_method { get; set; }
        public string? payment_method { get; set; }
        public virtual DeliveryDiscount? delivery_discount { get; set; }
        public virtual DeliveryInformation? delivery_information { get; set; }
        public virtual Totals? totals { get; set; }
        public virtual BillingInformation? billing_information { get; set; }
        public virtual List<Item>? items { get; set; }
        public virtual List<Discount>? discounts { get; set; }
    }
}
