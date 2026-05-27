using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class StoneConfiguration : IEntityTypeConfiguration<Stone>
    {
        public void Configure(EntityTypeBuilder<Stone> builder)
        {
            builder.HasData(
                new Stone { Id = 1, StoneTypeId = 1, UnitId = 2, StoneScaleId = 1, CostPrice = 200m, StoneSettingId = 1, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Stone { Id = 2, StoneTypeId = 1, UnitId = 2, StoneScaleId = 2, CostPrice = 300m, StoneSettingId = 2, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Stone { Id = 3, StoneTypeId = 1, UnitId = 2, StoneScaleId = 3, CostPrice = 350m, StoneSettingId = 3, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Stone { Id = 4, StoneTypeId = 1, UnitId = 2, StoneScaleId = 4, CostPrice = 400m, StoneSettingId = 4, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}


