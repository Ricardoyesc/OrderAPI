using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Uber;
using Microsoft.EntityFrameworkCore;

namespace Entities.Context
{
    public class DatabaseContext : DbContext
    {
        DbSet<DidiOrder> DidiOrder;
        DbSet<UberOrder> UberOrder;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
