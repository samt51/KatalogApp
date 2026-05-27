using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class UnitsConfiguration : IEntityTypeConfiguration<Units>
    {
        public void Configure(EntityTypeBuilder<Units> builder)
        {
            builder.HasData(
                new Units { Id = 1, Name = "Adet", Code = "Ad", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Units { Id = 2, Name = "Ct", Code = "Ct", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Units { Id = 3, Name = "Gram", Code = "Gr", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}

