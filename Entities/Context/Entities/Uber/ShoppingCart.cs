using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class ShoppingCart
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string CartId { get; set; }

    public virtual List<CartItem> Items { get; set; }

    public virtual List<FulfillmentIssue> FulfillmentIssues { get; set; }
    public string SpecialInstructions { get; set; }
    public bool IncludeSingleUseItems { get; set; }

    public virtual RestrictedItems RestrictedItems { get; set; }
}