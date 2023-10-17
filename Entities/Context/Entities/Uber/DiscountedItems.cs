using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class DiscountedItems
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string ExternalId { get; set; }
    public int DiscountedQuantity { get; set; }
    public int DiscountAmountApplied { get; set; }
}