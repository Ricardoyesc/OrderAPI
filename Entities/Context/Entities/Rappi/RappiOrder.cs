using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Entities.Context.Entities.Rappi
{
    public class RappiOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public virtual OrderDetail? order_detail { get; set; }
        public virtual Store? store { get; set; }
        public virtual Customer? customer { get; set; }
        [JsonIgnore]
        public Order order { get; set; } = new Order() { provider = Catalogs.Provider.RAPPI };
    }
}
