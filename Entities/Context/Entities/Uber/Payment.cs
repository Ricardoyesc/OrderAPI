using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public virtual PaymentDetail payment_detail { get; set; }
        public virtual ItemCharges item_charges { get; set; }
        public virtual Fees fees { get; set; }
        public virtual Tips tips { get; set; }
        public virtual Promotions promotions { get; set; }
        public virtual Adjustment adjustment { get; set; }
        public virtual CashAmountDue cash_amount_due { get; set; }

        public virtual TaxReporting tax_reporting { get; set; }
    }
}