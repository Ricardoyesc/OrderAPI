using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PromotionDetail
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string ExternalPromotionId { get; set; }
    public string Type { get; set; }
    public string DiscountValue { get; set; }
    public string DiscountPercentage { get; set; }
    public int DiscountDeliveryFeeValue { get; set; }

    public virtual List<DiscountedItem> DiscountedItems { get; set; }
}
