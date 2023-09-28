using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string sku { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<string> comments { get; set; }
        public int price { get; set; }
        public int percentage_discount { get; set; }
        public int quantity { get; set; }
        public List<SubItem> subitems { get; set; }
    }

}
