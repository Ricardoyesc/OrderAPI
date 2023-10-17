using System.ComponentModel.DataAnnotations;

namespace Entities.Context.Entities.Uber
{
    public class MetaInfo
    {
        [Key]
        public string? resource_id { get; set; }
        public string? resource_href { get; set; }
    }

}