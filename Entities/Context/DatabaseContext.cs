using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Uber;
using Microsoft.EntityFrameworkCore;

namespace Entities.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DidiOrder> DidiOrders { get; set; }
        public DbSet<PriceInfo> PricesInfo { get; set; }
        public DbSet<PromotionDetail> PromotionDetails { get; set; }
        public DbSet<Promotion> PromotionsInfo { get; set; }
        public DbSet<ReceiveAddress> ReceiveAddresses { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }
        public DbSet<ShopPhone> ShopPhones { get; set; }
        public DbSet<SubItem> SubItems { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
