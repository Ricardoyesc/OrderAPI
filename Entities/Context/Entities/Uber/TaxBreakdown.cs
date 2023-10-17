using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TaxBreakdown
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string InstanceId { get; set; }
    public string Description { get; set; }

    public virtual Money GrossAmount { get; set; }
    public virtual Money NetAmount { get; set; }
}
