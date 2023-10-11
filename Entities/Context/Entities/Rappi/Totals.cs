using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class Totals
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int total_products { get; set; }
        public int total_discounts { get; set; }
        public int total_order { get; set; }
        public int total_to_pay { get; set; }
        public int discount_by_support { get; set; }
        public virtual Charge? charges { get; set; }
        public virtual OtherTotal? other_totals { get; set; }
    }

}
