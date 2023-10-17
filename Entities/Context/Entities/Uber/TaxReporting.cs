using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class TaxReporting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual List<TaxBreakdown> Breakdown { get; set; }
    public virtual List<FeeDetail> Fees { get; set; }
    public virtual List<UberPromotionDetail> Promotions { get; set; }
}