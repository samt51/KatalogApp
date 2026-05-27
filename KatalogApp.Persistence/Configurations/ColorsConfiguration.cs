using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KatalogApp.Persistence.Configurations
{
    public class ColorsConfiguration : IEntityTypeConfiguration<Colors>
    {
        public void Configure(EntityTypeBuilder<Colors> builder)
        {
            builder.HasData(
                new Colors { Id = 1, Name = "D", Code = "D", ColorType = "Stone", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 2, Name = "E", Code = "E", ColorType = "Stone", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 3, Name = "F", Code = "F", ColorType = "Stone", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 4, Name = "G", Code = "G", ColorType = "Stone", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 5, Name = "H", Code = "H", ColorType = "Stone", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 6, Name = "Beyaz Altın", Code = "WHT", ColorType = "Metal", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 7, Name = "Sarı Altın", Code = "YLW", ColorType = "Metal", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 8, Name = "Rose Altın", Code = "RSE", ColorType = "Metal", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false },
                new Colors { Id = 9, Name = "Platin", Code = "PLT", ColorType = "Metal", CreatedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), IsDeleted = false }
            );
        }
    }
}

