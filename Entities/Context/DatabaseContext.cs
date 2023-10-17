using Entities.Context.Entities.Uber;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<RappiOrder> RappiOrders { get; set; }
        public DbSet<DidiOrder> DidiOrders { get; set; }
        public DbSet<UberOrder> UberOrders { get; set; }
        public DbSet<TimeRange> TimeRanges { get; set; }
        public DbSet<MetaInfo> MetaInfos { get; set; }
        public DbSet<OAuthToken> OAuthTokens { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Money> Monies { get; set; }
        public DbSet<PriceBreakdown> PriceBreakdowns { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Adjustment> Adjustments { get; set; }
        public DbSet<TaxReporting> TaxReportings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RemittanceSummary> RemittanceSummaries { get; set; }
        public DbSet<PreparationTime> PreparationTimes { get; set; }
        public DbSet<EligibleActions> EligibleActions { get; set; }
        public DbSet<FailureInfo> FailureInfos { get; set; }
        public DbSet<RetailerLoyaltyInfo> RetailerLoyaltyInfos { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Discounted> Discounteds { get; set; }
        public DbSet<DiscountedItems> DiscountedItems { get; set; }
        public DbSet<CustomerRequests> CustomerRequests { get; set; }
        public DbSet<RestrictedItems> RestrictedItems { get; set; }

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
