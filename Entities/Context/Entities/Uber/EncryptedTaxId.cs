using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class EncryptedTaxId
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string key { get; set; }
        public string cipher_text { get; set; }
    }
}