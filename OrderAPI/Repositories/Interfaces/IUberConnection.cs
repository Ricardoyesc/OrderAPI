using Entities.Context.Entities.Rappi;
using Entities.Context.Entities.Uber;
using Entities.Models;

namespace OrderAPI.Repositories.Interfaces
{
    public interface IUberConnection
    {
        public Task HandleWebhook(UberWebhook webhook);
    }
}
