using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber;

public class SelectedModifierGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string ModifierGroupId { get; set; }
    public string Title { get; set; }
    public string ExternalData { get; set; }

    public virtual List<SelectedModifierItem> SelectedItems { get; set; }
    public virtual List<RemovedModifierItem> RemovedItems { get; set; }
}