using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Rappi;
using Entities.Context.Entities.Uber;

namespace OrderAPI.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public Task<int> StoreUberOrder(UberOrder order);
        public Task<DidiOrder> StoreDidiOrder(DidiOrder order);
        public Task<RappiOrder> StoreRappiOrder(RappiOrder order);
    }
}
