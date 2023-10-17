using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class Promotions
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual Money Total { get; set; }
    public virtual PromotionDetail Details { get; set; }
    public virtual Money OrderTotalExcludingPromos { get; set; }
}