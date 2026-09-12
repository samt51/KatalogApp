using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KatalogApp.Persistence.Context
{
        public class KatalogAppDbContext : DbContext
    {
        public KatalogAppDbContext(DbContextOptions<KatalogAppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,4)");
            }



            modelBuilder.Entity<OrderRecord>().HasKey(o => o.Id);
            modelBuilder.Entity<OrderRecord>().HasIndex(o => new { o.AccountId, o.RequestId }).IsUnique();
            modelBuilder.Entity<OrderRecord>().HasIndex(o => o.OrderNumber).IsUnique();
            modelBuilder.Entity<OrderRecord>().HasIndex(o => o.CreatedUtc);
            modelBuilder.Entity<OrderRecord>().HasMany(o => o.Items).WithOne().HasForeignKey(i => i.OrderId);
            modelBuilder.Entity<OrderRecord>().HasOne(o => o.Document).WithOne().HasForeignKey<OrderDocument>(d => d.OrderId);
            modelBuilder.Entity<OrderRecord>().HasOne<Users>().WithMany().HasForeignKey(o => o.AccountId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderDocument>().HasKey(d => d.OrderId);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KatalogAppDbContext).Assembly);
        }

        public DbSet<OrderRecord> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderDocument> OrderDocuments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductMetal> ProductMetals { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductStone> ProductStones { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Stone> Stones { get; set; }
        public DbSet<StoneScale> StoneScales { get; set; }
        public DbSet<StoneSetting> StoneSettings { get; set; }
        public DbSet<StoneType> StoneTypes { get; set; }
        public DbSet<StoneCut> StoneCuts { get; set; }
        public DbSet<StoneClarity> StoneClarities { get; set; }
        public DbSet<MetalType> MetalTypes { get; set; }
        public DbSet<MetalPurity> MetalPurities { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserPricingProfile> UserPricingProfiles { get; set; }
        public DbSet<UserStonePrice> UserStonePrices { get; set; }
        public DbSet<UserPolishingCost> UserPolishingCosts { get; set; }
        public DbSet<UserSettingPrice> UserSettingPrices { get; set; }
        public DbSet<UserActionLog> UserActionLogs { get; set; }
        public DbSet<PolishingCost> PolishingCosts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<DefinitionTranslation> DefinitionTranslations { get; set; }
        public DbSet<CatalogLanguage> CatalogLanguages { get; set; }
    }
}




