using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TaxReporting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual List<TaxBreakdown> Breakdown { get; set; }
    public virtual List<FeeDetail> Fees { get; set; }
    public virtual List<PromotionDetail> Promotions { get; set; }
}
