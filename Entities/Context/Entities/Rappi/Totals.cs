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
        public List<Charge> charges { get; set; }
        public List<OtherTotal> other_totals { get; set; }
    }

}
