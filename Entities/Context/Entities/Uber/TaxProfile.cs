using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TaxProfile
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string TaxIds { get; set; }
    public string TaxIdType { get; set; }
    public string CustomerFullName { get; set; }
    public string Email { get; set; }
    public string LegalEntityName { get; set; }
    public string BillingAddress { get; set; }
    public string Country { get; set; }

    public virtual EncryptedTaxId EncryptedTaxId { get; set; }
}
