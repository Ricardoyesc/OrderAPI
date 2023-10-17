using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class CashAmountDue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? display_amount { get; set; }

        public virtual Money? net { get; set; }
        public virtual Money? tax { get; set; }
        public virtual Money? gross { get; set; }
        public bool is_tax_inclusive { get; set; }
    }
}