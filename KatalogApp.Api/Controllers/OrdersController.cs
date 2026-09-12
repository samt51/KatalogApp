using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using KatalogApp.Api.Models;
using KatalogApp.Api.Services;
using KatalogApp.Domain.Entities;
using KatalogApp.Persistence.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KatalogApp.Api.Controllers;
[ApiController, Authorize, Route("api/orders")]
public sealed class OrdersController(KatalogAppDbContext db, OrderEmailService mail, ILogger<OrdersController> logger) : ControllerBase
{
    private int AccountId => int.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var id) ? id : 0;
    private async Task<bool> IsAdmin() => await db.Users.AnyAsync(u => u.Id == AccountId && !u.IsDeleted && !u.IsLocked && (u.RoleId == 1 || u.RoleId == 2));
    private static object Result(object data, int count = 0) => new { isSuccess = true, statusCode = 200, data, count, errors = Array.Empty<string>() };
    private IActionResult Error(int code, string message) => StatusCode(code, new { isSuccess = false, statusCode = code, errors = new[] { message } });
    private static object Summary(OrderRecord o) => new { o.Id, o.OrderNumber, o.CreatedUtc, o.AccountId, o.AccountName, o.AccountEmail, o.AccountCompany, o.CompanyName, o.FirstName, o.LastName, o.PhoneNumber, o.EmailStatus, o.EmailSentUtc, ItemCount = o.Items.Count, TotalQuantity = o.Items.Sum(i => i.Quantity) };

    [HttpPost, RequestSizeLimit(30 * 1024 * 1024)]
    public async Task<IActionResult> Create(ConfirmOrderRequest request)
    {
        if (request.RequestId == Guid.Empty || request.Items == null || request.Items.Any(i => i == null || i.Stones == null || i.Stones.Any(s => s == null))) return Error(400, "Geçersiz sipariş.");
        var account = await db.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == AccountId && !u.IsDeleted && !u.IsLocked);
        if (account == null) return Error(403, "Hesap bulunamadı veya kullanıma kapalı.");
        byte[] pdf;
        try { pdf = Convert.FromBase64String(request.PdfBase64); }
        catch (FormatException) { return Error(400, "PDF dosyası geçersiz."); }
        if (pdf.Length < 10 || pdf.Length > 20 * 1024 * 1024 || !pdf.AsSpan(0, 5).SequenceEqual("%PDF-"u8)
            || !Encoding.ASCII.GetString(pdf, Math.Max(0, pdf.Length - 1024), Math.Min(1024, pdf.Length)).Contains("%%EOF"))
            return Error(400, "Geçerli ve en fazla 20 MB boyutunda bir PDF gereklidir.");
        var fingerprint = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new { request.CompanyName, request.FirstName, request.LastName, request.PhoneNumber, request.Items }))));
        var order = await db.Orders.Include(o => o.Items).FirstOrDefaultAsync(o => o.AccountId == account.Id && o.RequestId == request.RequestId);
        if (order != null && order.RequestHash != fingerprint) return Error(409, "Bu onay başka bir sipariş içeriği için kullanılmış.");
        if (order == null)
        {
            var codes = request.Items.Select(i => i.Code).Distinct().ToList();
            var products = await db.Products.AsNoTracking().Where(p => codes.Contains(p.Code) && !p.IsDeleted).Select(p => new { p.Id, p.Code, p.Name }).ToListAsync();
            if (request.Items.Any(i => !products.Any(p => p.Code == i.Code && (!i.ProductId.HasValue || p.Id == i.ProductId)))) return Error(400, "Siparişte bulunamayan bir ürün var. Sepetinizi kontrol edin.");
            var id = Guid.NewGuid();
            order = new OrderRecord { Id = id, RequestId = request.RequestId, OrderNumber = $"NAIF-{DateTime.UtcNow:yyyyMMdd}-{id.ToString("N")[..12].ToUpperInvariant()}", CreatedUtc = DateTime.UtcNow,
                AccountId = account.Id, AccountName = (account.FirstName + " " + account.LastName).Trim(), AccountEmail = account.Email, AccountCompany = account.CompanyName ?? "",
                CompanyName = request.CompanyName.Trim(), FirstName = request.FirstName.Trim(), LastName = request.LastName.Trim(), PhoneNumber = request.PhoneNumber.Trim(), RequestHash = fingerprint,
                Document = new OrderDocument { OrderId = id, Content = pdf },
                Items = request.Items.Select(i => { var p = products.First(p => p.Code == i.Code); return new OrderLine { ProductId = p.Id, Code = p.Code, ProductName = p.Name,
                    Category = i.Category ?? "", Price = i.Price ?? "", Ayar = i.Ayar ?? "", Renk = i.Renk ?? "", Gram = i.Gram ?? "", Quantity = i.Quantity, Note = i.Note ?? "", StonesJson = JsonSerializer.Serialize(i.Stones) }; }).ToList() };
            db.Orders.Add(order);
            try { await db.SaveChangesAsync(); }
            catch (DbUpdateException)
            {
                db.ChangeTracker.Clear();
                order = await db.Orders.Include(o => o.Items).FirstOrDefaultAsync(o => o.AccountId == account.Id && o.RequestId == request.RequestId);
                if (order == null) throw;
                if (order.RequestHash != fingerprint) return Error(409, "Bu onay başka bir sipariş içeriği için kullanılmış.");
            }
        }
        // Claim notification atomically; duplicate requests never send another email.
        await Notify(order.Id, retry: false);
        await db.Entry(order).ReloadAsync();
        return Ok(Result(Summary(order)));
    }

    [HttpGet]
    public async Task<IActionResult> List(int page = 1, string? search = null)
    {
        if (!await IsAdmin()) return Forbid();
        page = Math.Max(1, page);
        var query = db.Orders.AsNoTracking();
        if (!string.IsNullOrWhiteSpace(search)) query = query.Where(o => o.OrderNumber.Contains(search) || o.AccountName.Contains(search) || o.AccountEmail.Contains(search) || o.CompanyName.Contains(search) || o.FirstName.Contains(search) || o.LastName.Contains(search) || o.Items.Any(i => i.Code.Contains(search)));
        var count = await query.CountAsync();
        var orders = await query.OrderByDescending(o => o.CreatedUtc).Skip((page - 1) * 30).Take(30).Include(o => o.Items).ToListAsync();
        return Ok(Result(orders.Select(Summary), count));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Detail(Guid id)
    {
        if (!await IsAdmin()) return Forbid();
        var o = await db.Orders.AsNoTracking().Include(x => x.Items).FirstOrDefaultAsync(x => x.Id == id);
        if (o == null) return NotFound();
        return Ok(Result(new { o.Id, o.OrderNumber, o.CreatedUtc, o.AccountId, o.AccountName, o.AccountEmail, o.AccountCompany, o.CompanyName, o.FirstName, o.LastName, o.PhoneNumber, o.EmailStatus, o.EmailSentUtc,
            Items = o.Items.OrderBy(i => i.Id).Select(i => new { i.ProductId, i.Code, i.ProductName, i.Category, i.Price, i.Ayar, i.Renk, i.Gram, i.Quantity, i.Note, Stones = JsonSerializer.Deserialize<List<ConfirmOrderStone>>(i.StonesJson) }) }));
    }

    [HttpGet("{id:guid}/pdf")]
    public async Task<IActionResult> Pdf(Guid id)
    {
        var o = await db.Orders.AsNoTracking().Where(o => o.Id == id).Select(o => new { o.AccountId, o.OrderNumber }).FirstOrDefaultAsync();
        if (o == null) return NotFound();
        if (o.AccountId != AccountId && !await IsAdmin()) return Forbid();
        var document = await db.OrderDocuments.AsNoTracking().FirstAsync(d => d.OrderId == id);
        return File(document.Content, "application/pdf", o.OrderNumber + ".pdf");
    }

    [HttpPost("{id:guid}/retry-email")]
    public async Task<IActionResult> RetryEmail(Guid id)
    {
        if (!await IsAdmin()) return Forbid();
        if (!await db.Orders.AnyAsync(o => o.Id == id)) return NotFound();
        await Notify(id, retry: true);
        var order = await db.Orders.AsNoTracking().Include(o => o.Items).FirstAsync(o => o.Id == id);
        return Ok(Result(Summary(order)));
    }

    private async Task Notify(Guid id, bool retry)
    {
        var claimed = await db.Orders.Where(o => o.Id == id && (o.EmailStatus == "Pending" || (retry && o.EmailStatus == "Failed")))
            .ExecuteUpdateAsync(s => s.SetProperty(o => o.EmailStatus, "Sending").SetProperty(o => o.EmailAttemptUtc, DateTime.UtcNow));
        if (claimed == 0) return;
        var sent = false;
        try
        {
            var o = await db.Orders.AsNoTracking().Include(o => o.Items).Include(o => o.Document).FirstAsync(o => o.Id == id);
            var request = new ConfirmOrderRequest { CompanyName = o.CompanyName, FirstName = o.FirstName, LastName = o.LastName, PhoneNumber = o.PhoneNumber,
                Items = o.Items.Select(i => new ConfirmOrderItem { ProductId = i.ProductId, Code = i.Code, ProductName = i.ProductName, Category = i.Category, Price = i.Price, Ayar = i.Ayar, Renk = i.Renk, Gram = i.Gram, Quantity = i.Quantity, Note = i.Note, Stones = JsonSerializer.Deserialize<List<ConfirmOrderStone>>(i.StonesJson) ?? new() }).ToList() };
            using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            sent = await mail.SendNewOrderAsync(request, o.AccountName + " [Hesap #" + o.AccountId + "]", o.AccountEmail, o.OrderNumber, o.Document.Content, timeout.Token);
        }
        catch (Exception ex) { logger.LogError(ex, "Sipariş {OrderId} bildirim hatası", id); }
        await db.Orders.Where(o => o.Id == id).ExecuteUpdateAsync(s => s.SetProperty(o => o.EmailStatus, sent ? "Sent" : "Failed").SetProperty(o => o.EmailSentUtc, sent ? DateTime.UtcNow : (DateTime?)null));
    }
}
