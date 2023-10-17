using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class FulfillmentIssue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string issue_type { get; set; }
        public string action_type { get; set; }
        public string cart_item_id { get; set; }
        public DateTime suspend_until { get; set; }
        public string store_response { get; set; }
    }
}