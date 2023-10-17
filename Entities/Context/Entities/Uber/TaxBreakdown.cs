using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class TaxBreakdown
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string instance_id { get; set; }
        public string description { get; set; }

        public virtual Money gross_amount { get; set; }
        public virtual Money net_amount { get; set; }
    }
}