using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Location
    {
        [Key]
        public string? id { get; set; }
        public string? type { get; set; }
        public string? street_address_line_one { get; set; }
        public string? street_address_line_two { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int unit_number { get; set; }

        public string? business_name { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public int postal_code { get; set; }
        public string? location_type_value { get; set; }
        public string? client_provided_street_address_line_one { get; set; }
    }
}