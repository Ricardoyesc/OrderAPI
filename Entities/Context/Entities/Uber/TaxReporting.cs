using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class TaxReporting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public virtual List<TaxBreakdown> breakdown { get; set; }
        public virtual List<FeeDetail> fees { get; set; }
        public virtual List<UberPromotionDetail> promotions { get; set; }
    }
}