using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class DeliveryInformation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string city { get; set; }
        public string complete_address { get; set; }
        public string street_number { get; set; }
        public string neighborhood { get; set; }
        public string complement { get; set; }
        public string postal_code { get; set; }
        public string street_name { get; set; }
    }

}
