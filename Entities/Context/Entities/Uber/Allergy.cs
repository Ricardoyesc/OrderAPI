using Entities.Context.Entities.Didi;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities.Context.Entities.Uber
{
    public class Allergy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? instructions { get; set; }
        [NotMapped]
        public List<string> Allergens
        {
            get
            {
                // Convert the list of Allergen entities to a list of strings
                return AllergensNames.Select(allergen => allergen.name).ToList();
            }
            set
            {
                // Convert the list of strings to a list of Allergen entities
                AllergensNames = value.Select(name => new Allergen { name = name }).ToList();
            }
        }
        [JsonIgnore]
        public virtual List<Allergen> AllergensNames { get; set; } = new List<Allergen>();
    }

}