using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class DeliveryPartner
    {
        [Key]
        public string? id { get; set; }
        public string? name { get; set; }
        public virtual Vehicle? vehicle { get; set; }
        public virtual Contact? contact { get; set; }
        public virtual CurrentLocation? current_location { get; set; }
    }
}