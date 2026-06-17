using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class StoneClarityConfiguration : IEntityTypeConfiguration<StoneClarity>
    {
        public void Configure(EntityTypeBuilder<StoneClarity> builder)
        {
            builder.HasData(
                new StoneClarity { Id = 1, Name = "SI", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneClarity { Id = 2, Name = "VS", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneClarity { Id = 3, Name = "VVS", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}

