using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class FailureInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string reason { get; set; }
        public string failure_attributed_to_party { get; set; }
        public bool will_merchant_be_paid { get; set; }
        public string description { get; set; }

        public virtual TimeRange time_range { get; set; }
    }
}