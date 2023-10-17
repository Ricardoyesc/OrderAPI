using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class FailureInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Reason { get; set; }
        public string FailureAttributedToParty { get; set; }
        public bool WillMerchantBePaid { get; set; }
        public string Description { get; set; }

        public virtual TimeRange TimeRange { get; set; }
    }
}