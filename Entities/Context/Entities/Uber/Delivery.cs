using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? delivery_id { get; set; }
        public string? status { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime estimated_pick_up_time { get; set; }
        public string? interaction_type { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime delivery_partner_marked_not_ready_time { get; set; }
        public string? instructions { get; set; }
        public virtual Location location { get; set; }
        public virtual DeliveryPartner delivery_partner { get; set; }
    }
}