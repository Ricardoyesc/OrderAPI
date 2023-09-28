using Entities.Context;
using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Rappi;
using Entities.Context.Entities.Uber;
using OrderAPI.Repositories.Interfaces;

namespace OrderAPI.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        readonly DatabaseContext _context;

        public OrdersRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<DidiOrder> StoreDidiOrder(DidiOrder order)
        {
            var res = (await _context.DidiOrders.AddAsync(order)).Entity;
            return res;
        }

        public async Task<RappiOrder> StoreRappiOrder(RappiOrder order)
        {
            var res = (await _context.RappiOrders.AddAsync(order)).Entity;
            return res;
        }

        public Task<int> StoreUberOrder(UberOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
