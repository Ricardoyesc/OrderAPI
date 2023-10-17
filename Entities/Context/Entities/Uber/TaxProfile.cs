using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class TaxProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string tax_ids { get; set; }
        public string tax_id_type { get; set; }
        public string customer_full_name { get; set; }
        public string email { get; set; }
        public string legal_entity_name { get; set; }
        public string billing_address { get; set; }
        public string country { get; set; }

        public virtual EncryptedTaxId encrypted_tax_id { get; set; }
    }
}