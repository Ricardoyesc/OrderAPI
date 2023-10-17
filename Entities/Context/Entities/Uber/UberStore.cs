using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class UberStore
    {
        [Key]
        public string? id { get; set; }
        public string? name { get; set; }

        public virtual List<PartnerIdentifier> partner_identifiers { get; set; }
    }
}