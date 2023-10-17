using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class PaymentDetail
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string OrderTotalDisplayAmount { get; set; }

    public virtual Money OrderTotalNet { get; set; }
    public virtual Money OrderTotalTax { get; set; }
    public virtual Money OrderTotalGross { get; set; }
    public bool IsTaxInclusive { get; set; }
}