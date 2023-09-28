using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DidiWebhook<T>
    {
        public long app_id { get; set; }
        public string app_shop_id { get; set; }
        public string type { get; set; }
        public int timestamp { get; set; }
        public T data { get; set; }
    }
}
