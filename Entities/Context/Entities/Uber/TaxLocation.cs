using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Uber
{
    public class TaxLocation
    {
        [Key]
        public string? id { get; set; }
        public string? country_iso2 { get; set; }
        public string? postal_code { get; set; }

    }
}