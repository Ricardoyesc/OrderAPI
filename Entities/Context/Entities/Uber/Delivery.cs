using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DeliveryId { get; set; }
        public string Status { get; set; }
        public DateTime EstimatedPickUpTime { get; set; }
        public string InteractionType { get; set; }
        public DateTime DeliveryPartnerMarkedNotReadyTime { get; set; }
        public string Instructions { get; set; }
        public virtual Location Location { get; set; }
        public virtual DeliveryPartner DeliveryPartner { get; set; }
    }
}