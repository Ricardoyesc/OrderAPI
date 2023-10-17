using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class TaxReporting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual TaxBreakdown? breakdown { get; set; }
        public virtual TaxLocation? origin { get; set; }
        public virtual TaxLocation? destination { get; set; }
        public virtual List<RemittanceSummary>? remittance_info { get; set; }
    }
}