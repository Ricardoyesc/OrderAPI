using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Uber
{
    public class MerchantFee
    {
        [Key]
        public string? id { get; set; }
        public CashAmountDue? amount { get; set; }
    }
}