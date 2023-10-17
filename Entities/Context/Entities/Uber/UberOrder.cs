using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public class UberOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string DisplayId { get; set; }
        public string ExternalId { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string PreparationStatus { get; set; }
        public string OrderingPlatform { get; set; }
        public string FulfillmentType { get; set; }
        public DateTime? ScheduledOrderTargetDeliveryStartTime { get; set; }
        public DateTime? ScheduledOrderTargetDeliveryEndTime { get; set; }
        public int StoreId { get; set; }
        public bool IsOrderAccuracyRisk { get; set; }
        public string StoreInstructions { get; set; }
        public DateTime? CompletedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool HasMembershipPass { get; set; }
        public virtual Store Store { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual List<Delivery> Deliveries { get; set; }
        public virtual List<ShoppingCart> Carts { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual PreparationTime PreparationTime { get; set; }
        public virtual ActionEligibility EligibleActions { get; set; }
        public virtual List<FailureInfo> FailureInfo { get; set; }
        public virtual RetailerLoyaltyInfo RetailerLoyaltyInfo { get; set; }
        [JsonIgnore]
        public Order order { get; set; } = new Order() { provider = Catalogs.Provider.UBER };
    }
}