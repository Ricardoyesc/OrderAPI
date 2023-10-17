using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PreparationTime
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int ReadyForPickupTimeSecs { get; set; }
    public string Source { get; set; }
    public DateTime ReadyForPickupTime { get; set; }
}
