using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class Promotion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string ExternalPromotionId { get; set; }
    public string Type { get; set; }
    public string DiscountValue { get; set; }
    public int DiscountPercentage { get; set; }
    public int DiscountDeliveryFeeValue { get; set; }

    public virtual List<DiscountedItems> DiscountedItems { get; set; }
}