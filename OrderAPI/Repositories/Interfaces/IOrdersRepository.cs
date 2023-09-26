using Entities.Context.Entities.Uber;

namespace OrderAPI.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        public Task<int> StoreUberOrder(UberOrder order);
    }
}
