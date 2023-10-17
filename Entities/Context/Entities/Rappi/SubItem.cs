using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Rappi
{
    public class SubItem
    {
        [Key]
        public string? id { get; set; }
        public string? sku { get; set; }
        public string? name { get; set; }
        public string? type { get; set; }
        public int price { get; set; }
        public int percentage_discount { get; set; }
        public int quantity { get; set; }
    }

}
