using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Context.Entities.Uber
{
    public class Money
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int amount_e5 { get; set; }
        public string? currency_code { get; set; } = string.Empty;
        public string? formatted { get; set; } = string.Empty;
    }
}