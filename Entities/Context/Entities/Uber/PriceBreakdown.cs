using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class PriceBreakdown
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string CartItemId { get; set; }

    public virtual Quantity Quantity { get; set; }
    public virtual Money Total { get; set; }
    public virtual Discount Discount { get; set; }
    public virtual Money Unit { get; set; }
    public bool IsTaxInclusive { get; set; }
}