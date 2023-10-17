using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Store
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string StoreId { get; set; }
    public string Name { get; set; }

    public virtual List<PartnerIdentifier> PartnerIdentifiers { get; set; }
}
