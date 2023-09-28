using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class BillingInformation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string address { get; set; }
        public string billing_type { get; set; }
        public string document_number { get; set; }
        public string document_type { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }

}
