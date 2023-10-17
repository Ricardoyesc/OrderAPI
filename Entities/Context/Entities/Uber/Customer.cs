using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CustomerId { get; set; }

        public string Name { get; set; }
        public string OrderHistory { get; set; }

        public virtual Contact Contact { get; set; }
        public bool IsPrimaryCustomer { get; set; }

        public virtual TaxProfile TaxProfile { get; set; }
        public bool CanResponseToFulfillmentIssues { get; set; }
    }
}