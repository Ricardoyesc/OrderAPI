using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class TaxBreakdown
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual List<FeeDetail> items { get; set; }
        public virtual List<FeeDetail> fees { get; set; }
        public virtual List<FeeDetail> promotions { get; set; }
    }
}