using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class MetalTypeConfiguration : IEntityTypeConfiguration<MetalType>
    {
        public void Configure(EntityTypeBuilder<MetalType> builder)
        {
            builder.HasData(
                new MetalType { Id = 1, Name = "Altın", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalType { Id = 2, Name = "Beyaz Altın", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalType { Id = 3, Name = "Rose Altın", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalType { Id = 4, Name = "Platin", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new MetalType { Id = 5, Name = "Gümüş", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}

