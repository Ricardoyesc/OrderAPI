using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Uber
{
    public class AdjustmentDetail
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? reason { get; set; }
        public virtual CashAmountDue amount { get; set; }
    }
}