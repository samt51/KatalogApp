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



            modelBuilder.ApplyConfigurationsFromAssembly(typeof(KatalogAppDbContext).Assembly);
        }

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
    }
}




