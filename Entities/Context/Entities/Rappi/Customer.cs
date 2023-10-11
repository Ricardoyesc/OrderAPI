using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Rappi
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? phone_number { get; set; }
        public string? document_number { get; set; }
        public string? user_type { get; set; }
    }

}
