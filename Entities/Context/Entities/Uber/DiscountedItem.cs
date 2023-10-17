using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class DiscountedItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CartItemId { get; set; }

        public virtual Money DiscountAmount { get; set; }
        public string ExternalItemDiscountId { get; set; }
    }
}
