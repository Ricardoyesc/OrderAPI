using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class PreparationTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int ready_for_pickup_time_secs { get; set; }
        public string source { get; set; }
        public DateTime ready_for_pickup_time { get; set; }
    }
}