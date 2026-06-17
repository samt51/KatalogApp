using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class StoneScalesConfiguration : IEntityTypeConfiguration<StoneScale>
    {
        public void Configure(EntityTypeBuilder<StoneScale> builder)
        {
            builder.HasData(
                new StoneScale { Id = 1, Name = "-6,5", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 2, Name = "+6,5", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 3, Name = "+11", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 4, Name = "+15", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 5, Name = "+20", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 6, Name = "+25", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 7, Name = "+30", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 8, Name = "+40", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 9, Name = "+50", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 10, Name = "+60", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 11, Name = "+70", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 12, Name = "+80", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 13, Name = "+90", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 14, Name = "+100", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 15, Name = "+110", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 16, Name = "+120", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 17, Name = "+130", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 18, Name = "+140", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 19, Name = "+150", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 20, Name = "+160", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 21, Name = "+170", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 22, Name = "+180", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 23, Name = "+190", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 24, Name = "+200", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 25, Name = "+210", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 26, Name = "+220", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 27, Name = "+230", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 28, Name = "+240", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 29, Name = "+250", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 30, Name = "+260", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 31, Name = "+270", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 32, Name = "+280", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 33, Name = "+290", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new StoneScale { Id = 34, Name = "+300", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}
