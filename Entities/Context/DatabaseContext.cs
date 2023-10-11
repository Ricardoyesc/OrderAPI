using Entities.Context.Entities.Didi;
using Entities.Context.Entities.Rappi;
using Entities.Context.Entities.Uber;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using static Entities.Context.Entities.Catalogs;

namespace Entities.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DeliveryInformation> DeliveriesInformation { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShopInfo> Shops { get; set; }
        public DbSet<PriceInfo> PricesInfo { get; set; }
        public DbSet<PromotionDetail> PromotionDetails { get; set; }
        public DbSet<Promotion> PromotionsInfo { get; set; }
        public DbSet<ReceiveAddress> ReceiveAddresses { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }
        public DbSet<ShopPhone> ShopPhones { get; set; }
        public DbSet<Entities.Didi.SubItem> DidiSubItems { get; set; }
        public DbSet<BillingInformation> BillingsInformation { get; set; }
        public DbSet<Totals> Totals { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<OrderItemInfo> OrderItems { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DeliveryDiscount> DeliveryDiscounts { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<OtherTotal> OtherTotals { get; set; }
        public DbSet<Entities.Rappi.SubItem> RappiSubItems { get; set; }
        public DbSet<MetaInfo> MetaInfos { get; set; }
        public DbSet<RappiOrder> RappiOrders { get; set; }
        public DbSet<DidiOrder> DidiOrders { get; set; }
        public DbSet<UberOrder> UberOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
