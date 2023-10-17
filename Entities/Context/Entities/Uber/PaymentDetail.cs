using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class PaymentDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool is_tax_inclusive { get; set; }
        public virtual CashAmountDue cash_amount_due { get; set; }
        public virtual CashAmountDue order_total { get; set; }
        public virtual ItemCharges item_charges { get; set; }
        public virtual Fees fees { get; set; }
        public virtual Tips tips { get; set; }
        public virtual Promotions promotions { get; set; }
        public virtual Adjustment adjustment { get; set; }

    }
}