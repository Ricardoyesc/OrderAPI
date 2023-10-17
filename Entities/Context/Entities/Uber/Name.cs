using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Uber
{
    public class Name
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? display_name { get; set; }
        public string? first_name {get; set;}
        public string? last_name {get; set;}
    }
}