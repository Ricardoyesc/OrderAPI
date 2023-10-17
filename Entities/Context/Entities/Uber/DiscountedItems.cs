using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class DiscountedItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string external_id { get; set; }
        public int discounted_quantity { get; set; }
        public int discount_amount_applied { get; set; }
    }
}