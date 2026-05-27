using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class StoneSettingConfiguration : IEntityTypeConfiguration<StoneSetting>
    {
        public void Configure(EntityTypeBuilder<StoneSetting> builder)
        {
            builder.HasOne(s => s.Unit)
                .WithMany(u => u.StoneSettings)
                .HasForeignKey(s => s.UnitId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new StoneSetting { Id = 1, UnitId = 1, SettingPrice = 0.50m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneSetting { Id = 2, UnitId = 1, SettingPrice = 0.70m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneSetting { Id = 3, UnitId = 2, SettingPrice = 30m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneSetting { Id = 4, UnitId = 2, SettingPrice = 40m, CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}
