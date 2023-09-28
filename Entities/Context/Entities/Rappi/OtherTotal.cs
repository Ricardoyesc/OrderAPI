using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class OtherTotal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int tip { get; set; }
        public int total_rappi_pay { get; set; }
        public int total_rappi_credits { get; set; }
    }

}
