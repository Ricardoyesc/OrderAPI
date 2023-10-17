using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string type { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string license_plate { get; set; }
        public bool is_autonomous { get; set; }
        public string handoff_instructions { get; set; }
        public string passcode { get; set; }
    }
}