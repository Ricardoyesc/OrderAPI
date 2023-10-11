using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class DeliveryDiscount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int total_percentage_discount { get; set; }
        public int total_value_discount { get; set; }
    }
}