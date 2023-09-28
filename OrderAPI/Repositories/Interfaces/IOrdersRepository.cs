using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Uber;

namespace OrderAPI.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public Task<int> StoreUberOrder(UberOrder order);
        public Task<int> StoreDidiOrder(DidiOrder order);
    }
}
