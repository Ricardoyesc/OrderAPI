using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class CashAmountDue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DisplayAmount { get; set; }

        public virtual Money Net { get; set; }
        public virtual Money Tax { get; set; }
        public virtual Money Gross { get; set; }
        public bool IsTaxInclusive { get; set; }
    }
}