using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class EligibleActions
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public bool CanAdjustReadyForPickupTime { get; set; }
    public bool CanMarkOutOfItem { get; set; }
    public bool Cancel { get; set; }
}