using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class Discount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int value { get; set; }
        public string? description { get; set; }
        public string? title { get; set; }
        public int? product_id { get; set; }
        public string? sku { get; set; }
        public string? type { get; set; }
        public int raw_value { get; set; }
        public string? value_type { get; set; }
        public int? max_value { get; set; }
        public bool includes_toppings { get; set; }
        public int percentage_by_rappi { get; set; }
        public int percentage_by_partners { get; set; }
        public int amount_by_rappi { get; set; }
        public int amount_by_partner { get; set; }
        public int discount_product_units { get; set; }
        public int? discount_product_unit_value { get; set; }
    }

}
