using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual PaymentDetail PaymentDetail { get; set; }
    public virtual ItemCharges ItemCharges { get; set; }
    public virtual Fees Fees { get; set; }
    public virtual Tips Tips { get; set; }
    public virtual Promotions Promotions { get; set; }
    public virtual Adjustment Adjustment { get; set; }
    public virtual CashAmountDue CashAmountDue { get; set; }

    public virtual TaxReporting TaxReporting { get; set; }
}
