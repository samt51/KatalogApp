using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class MetalPurityConfiguration : IEntityTypeConfiguration<MetalPurity>
    {
        public void Configure(EntityTypeBuilder<MetalPurity> builder)
        {
            builder.HasData(
                new MetalPurity { Id = 1, Name = "8K", Milyem = 0.333m, Density = 11.0m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalPurity { Id = 2, Name = "9K", Milyem = 0.375m, Density = 11.2m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalPurity { Id = 3, Name = "10K", Milyem = 0.416m, Density = 11.6m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalPurity { Id = 4, Name = "14K", Milyem = 0.585m, Density = 13.4m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalPurity { Id = 5, Name = "18K", Milyem = 0.750m, Density = 15.5m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}
