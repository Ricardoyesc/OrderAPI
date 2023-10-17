using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public class UberOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string id { get; set; }
        public string order_id { get; set; }
        public string display_id { get; set; }
        public string external_id { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public string preparation_status { get; set; }
        public string ordering_platform { get; set; }
        public string fulfillment_type { get; set; }
        public DateTime? scheduled_order_target_delivery_start_time { get; set; }
        public DateTime? scheduled_order_target_delivery_end_time { get; set; }
        public int store_id { get; set; }
        public bool is_order_accuracy_risk { get; set; }
        public string store_instructions { get; set; }
        public DateTime? completed_time { get; set; }
        public DateTime created_time { get; set; }
        public bool has_membership_pass { get; set; }
        public virtual UberStore store { get; set; }
        public virtual List<UberCustomer> customers { get; set; }
        public virtual List<Delivery> deliveries { get; set; }
        public virtual List<ShoppingCart> carts { get; set; }
        public virtual Payment payment { get; set; }
        public virtual PreparationTime preparation_time { get; set; }
        public virtual ActionEligibility eligible_actions { get; set; }
        public virtual List<FailureInfo> failure_info { get; set; }
        public virtual RetailerLoyaltyInfo retailer_loyalty_info { get; set; }
        [JsonIgnore]
        public Order order { get; set; } = new Order() { provider = Catalogs.Provider.UBER };
    }
}