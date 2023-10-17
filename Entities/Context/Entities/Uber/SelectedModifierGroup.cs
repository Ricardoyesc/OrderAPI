using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class SelectedModifierGroup
    {
        [Key]
        public string? id { get; set; }
        public string? title { get; set; }
        public string? external_data { get; set; }

        public virtual List<SelectedModifierItem> selected_items { get; set; }
        public virtual List<RemovedModifierItem> removed_items { get; set; }
    }
}