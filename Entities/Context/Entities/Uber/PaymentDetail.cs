using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class PaymentDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string order_total_display_amount { get; set; }

        public virtual Money order_total_net { get; set; }
        public virtual Money order_total_tax { get; set; }
        public virtual Money order_total_gross { get; set; }
        public bool is_tax_inclusive { get; set; }
    }
}