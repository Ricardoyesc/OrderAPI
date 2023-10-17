using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RestrictedItems
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public bool ContainAlcoholicItem { get; set; }
    public bool ContainTobaccoProduct { get; set; }
}
