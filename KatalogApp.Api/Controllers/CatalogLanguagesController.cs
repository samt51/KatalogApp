using KatalogApp.Domain.Entities;
using KatalogApp.Persistence.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KatalogApp.Api.Controllers;

[ApiController]
[Route("api/catalog-languages")]
public class CatalogLanguagesController : ControllerBase
{
    private readonly KatalogAppDbContext _db;
    public CatalogLanguagesController(KatalogAppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken ct) => Ok(new
    {
        isSuccess = true,
        data = await _db.CatalogLanguages.AsNoTracking().Where(x => !x.IsDeleted && x.IsActive)
            .OrderBy(x => x.Id).Select(x => new { x.Id, x.Code, x.Name }).ToListAsync(ct)
    });

    [HttpPost]
    public async Task<IActionResult> Create(LanguageRequest request, CancellationToken ct)
    {
        var code = Normalize(request.Code);
        if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(request.Name)) return BadRequest();
        if (await _db.CatalogLanguages.AnyAsync(x => x.Code == code && !x.IsDeleted, ct))
            return Conflict(new { isSuccess = false, errors = new[] { "Dil kodu zaten mevcut." } });
        _db.CatalogLanguages.Add(new CatalogLanguage { Code = code, Name = request.Name.Trim(), IsActive = true });
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true });
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    {
        var row = await _db.CatalogLanguages.FirstOrDefaultAsync(x => x.Id == id, ct);
        if (row is null) return NotFound();
        row.IsDeleted = true;
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true });
    }

    private static string Normalize(string? code) => (code ?? "").Trim().ToLowerInvariant();
    public sealed class LanguageRequest { public string Code { get; set; } = ""; public string Name { get; set; } = ""; }
}
