using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string CartItemId { get; set; }
        public string Title { get; set; }
        public string ExternalData { get; set; }

        public string CustomerId { get; set; }
        public virtual Quantity Quantity { get; set; }
        public virtual Quantity DefaultQuantity { get; set; }

        public virtual CustomerRequests CustomerRequests { get; set; }

        public virtual List<SelectedModifierGroup> SelectedModifierGroups { get; set; }
        public string PictureUrl { get; set; }
    }
}