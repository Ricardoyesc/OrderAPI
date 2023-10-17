using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class FulfillmentIssue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IssueType { get; set; }
        public string ActionType { get; set; }
        public string CartItemId { get; set; }
        public DateTime SuspendUntil { get; set; }
        public string StoreResponse { get; set; }
    }
}