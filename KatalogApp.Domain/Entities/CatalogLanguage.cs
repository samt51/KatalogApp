using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities;

public class CatalogLanguage : BaseEntity
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
