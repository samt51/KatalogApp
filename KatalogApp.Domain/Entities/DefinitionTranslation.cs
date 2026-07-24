using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities;

public class DefinitionTranslation : BaseEntity
{
    public string EntityType { get; set; } = string.Empty;
    public int EntityId { get; set; }
    public string LanguageCode { get; set; } = "en";
    public string TranslatedName { get; set; } = string.Empty;
}
