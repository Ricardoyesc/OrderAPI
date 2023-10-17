using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class DeliveryPartner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PartnerId { get; set; }

        public string Name { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual CurrentLocation CurrentLocation { get; set; }
    }
}
