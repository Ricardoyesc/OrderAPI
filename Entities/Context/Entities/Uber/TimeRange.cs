using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public class TimeRange
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime start_time { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime end_time { get; set; }
    }
}