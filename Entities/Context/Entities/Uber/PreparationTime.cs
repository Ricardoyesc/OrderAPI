using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public class PreparationTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ready_for_pickup_time_secs { get; set; }
        public string? source { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ready_for_pickup_time { get; set; }
    }
}