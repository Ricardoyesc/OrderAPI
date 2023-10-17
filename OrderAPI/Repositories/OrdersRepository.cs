using Entities.Context;
using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Rappi;
using Entities.Context.Entities.Uber;
using Microsoft.EntityFrameworkCore;
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

        public async Task<DidiOrder?> StoreDidiOrder(DidiOrder order)
        {
            await _context.DidiOrders.AddAsync(order);
            var rows = await _context.SaveChangesAsync();
            return rows > 0 ? order : null;
        }

        public async Task<RappiOrder?> StoreRappiOrder(RappiOrder order)
        {
            await _context.RappiOrders.AddAsync(order);
            var rows = await _context.SaveChangesAsync();
            return rows > 0 ? order : null;
        }

        public async Task<UberOrder?> StoreUberOrder(UberOrder order)
        { 
            await _context.UberOrders.AddAsync(order);
            var rows = await _context.SaveChangesAsync();
            return rows > 0 ? order : null;
        }
    }
}
