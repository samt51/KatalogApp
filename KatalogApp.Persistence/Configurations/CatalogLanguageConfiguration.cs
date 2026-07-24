using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatalogApp.Persistence.Configurations;

public class CatalogLanguageConfiguration : IEntityTypeConfiguration<CatalogLanguage>
{
    public void Configure(EntityTypeBuilder<CatalogLanguage> builder)
    {
        builder.Property(x => x.Code).HasMaxLength(10).IsRequired();
        builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        builder.HasIndex(x => x.Code).IsUnique();
        builder.HasData(
            new CatalogLanguage { Id = 1, Code = "tr", Name = "Türkçe", IsActive = true, CreatedDate = new DateTime(2026, 1, 1) },
            new CatalogLanguage { Id = 2, Code = "en", Name = "English", IsActive = true, CreatedDate = new DateTime(2026, 1, 1) },
            new CatalogLanguage { Id = 3, Code = "it", Name = "Italiano", IsActive = true, CreatedDate = new DateTime(2026, 1, 1) });
    }
}
