using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context.Entities
{
    public class Catalogs
    {
        public enum DeliveryStatus
        {
            ASSIGNED = 120,
            ARRIVED_AT_B = 130,
            TAKEN = 140,
            ARRIVED_AT_C = 150,
            FINISH = 160,
            CANCEL = 170,
            REASSIGNED = 180,
            ABORTED = 190
        }
        public enum Provider
        {
            DIDI = 1,
            UBER = 2,
            RAPPI = 3
        }
    }
}
