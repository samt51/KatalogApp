using KatalogApp.Domain.Entities;
using KatalogApp.Persistence.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KatalogApp.Api.Controllers;

[ApiController]
[Route("api/definition-translations")]
public class DefinitionTranslationsController : ControllerBase
{
    private readonly KatalogAppDbContext _db;
    public DefinitionTranslationsController(KatalogAppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string entityType, [FromQuery] int entityId,
        [FromQuery] string languageCode = "en", CancellationToken ct = default)
    {
        var value = await _db.DefinitionTranslations.AsNoTracking()
            .Where(x => !x.IsDeleted && x.EntityType == entityType && x.EntityId == entityId
                && x.LanguageCode == languageCode)
            .Select(x => x.TranslatedName).FirstOrDefaultAsync(ct);
        return Ok(new { isSuccess = true, data = value ?? string.Empty });
    }

    [HttpPut]
    public async Task<IActionResult> Upsert(TranslationRequest request, CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(request.EntityType) || request.EntityId <= 0)
            return BadRequest(new { isSuccess = false, errors = new[] { "Geçersiz tanım." } });

        var language = string.IsNullOrWhiteSpace(request.LanguageCode) ? "en" : request.LanguageCode.Trim().ToLowerInvariant();
        var row = await _db.DefinitionTranslations.FirstOrDefaultAsync(x =>
            x.EntityType == request.EntityType && x.EntityId == request.EntityId && x.LanguageCode == language, ct);
        if (string.IsNullOrWhiteSpace(request.TranslatedName))
        {
            if (row is not null) row.IsDeleted = true;
        }
        else if (row is null)
        {
            _db.DefinitionTranslations.Add(new DefinitionTranslation
            {
                EntityType = request.EntityType.Trim(), EntityId = request.EntityId,
                LanguageCode = language, TranslatedName = request.TranslatedName.Trim()
            });
        }
        else
        {
            row.TranslatedName = request.TranslatedName.Trim();
            row.IsDeleted = false;
            row.ModifyDate = DateTime.Now;
        }
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true });
    }

    public sealed class TranslationRequest
    {
        public string EntityType { get; set; } = string.Empty;
        public int EntityId { get; set; }
        public string LanguageCode { get; set; } = "en";
        public string? TranslatedName { get; set; }
    }
}
