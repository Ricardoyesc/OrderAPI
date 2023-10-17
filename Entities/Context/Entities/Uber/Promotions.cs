using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Promotions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public virtual Money total { get; set; }
        public virtual UberPromotionDetail details { get; set; }
        public virtual Money order_total_excluding_promos { get; set; }
    }
}