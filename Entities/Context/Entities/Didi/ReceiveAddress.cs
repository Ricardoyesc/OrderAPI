using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Didi
{
    public class ReceiveAddress
    {
        [Key]
        public long uid { get; set; }
        public string? name { get; set; } = default!;
        public string? first_name { get; set; } = default!;
        public string? last_name { get; set; } = default!;
        public string? calling_code { get; set; } = default!;
        public string? phone { get; set; } = default!;
        public string? city { get; set; } = default!;
        public string? country_code { get; set; } = default!;
        public string? poi_address { get; set; } = default!;
        public string? house_number { get; set; } = default!;
        public double poi_lat { get; set; }
        public double poi_lng { get; set; }
        public string? coordinate_type { get; set; } = default!;
        public string? poi_display_name { get; set; } = default!;

    }


}
