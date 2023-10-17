using Entities.Context.Entities.Didi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DidiOrderModel
    {
        public long order_id { get; set; }
        public DidiOrder order_info { get; set; } = new DidiOrder();
    }
}
