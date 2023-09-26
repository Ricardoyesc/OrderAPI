using Entities.Context;
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

        public Task<int> StoreUberOrder(UberOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
