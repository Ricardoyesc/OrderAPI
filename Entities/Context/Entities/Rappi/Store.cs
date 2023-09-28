using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Rappi
{
    public class Store
    {
        [Key]
        public string internal_id { get; set; }
        public string external_id { get; set; }
        public string name { get; set; }
    }

}
