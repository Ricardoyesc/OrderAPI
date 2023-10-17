using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class UberStore
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string StoreId { get; set; }
    public string Name { get; set; }

    public virtual List<PartnerIdentifier> PartnerIdentifiers { get; set; }
}