using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KatalogApp.Persistence.Configurations;

public class DefinitionTranslationConfiguration : IEntityTypeConfiguration<DefinitionTranslation>
{
    public void Configure(EntityTypeBuilder<DefinitionTranslation> builder)
    {
        builder.Property(x => x.EntityType).HasMaxLength(50).IsRequired();
        builder.Property(x => x.LanguageCode).HasMaxLength(10).IsRequired();
        builder.Property(x => x.TranslatedName).HasMaxLength(250).IsRequired();
        builder.HasIndex(x => new { x.EntityType, x.EntityId, x.LanguageCode }).IsUnique();
    }
}
