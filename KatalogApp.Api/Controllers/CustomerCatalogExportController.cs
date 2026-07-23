using ClosedXML.Excel;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace KatalogApp.Api.Controllers;

[ApiController]
[Route("api/customers/{customerId:int}/catalog-export")]
public sealed class CustomerCatalogExportController : ControllerBase
{
    private static readonly HttpClient ImageClient = new(new HttpClientHandler
    {
        ServerCertificateCustomValidationCallback = (request, _, _, errors) =>
            errors == System.Net.Security.SslPolicyErrors.None
            || string.Equals(request.RequestUri?.Host, "b2b.naifjewellery.com", StringComparison.OrdinalIgnoreCase)
    })
    {
        Timeout = TimeSpan.FromSeconds(20)
    };
    private static readonly SemaphoreSlim ImageDownloadGate = new(24);
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _environment;
    private readonly string _catalogImageBaseUrl;
    private readonly ILogger<CustomerCatalogExportController> _logger;

    public CustomerCatalogExportController(IUnitOfWork unitOfWork, IWebHostEnvironment environment,
        IConfiguration configuration, ILogger<CustomerCatalogExportController> logger)
    {
        _unitOfWork = unitOfWork;
        _environment = environment;
        _catalogImageBaseUrl = configuration["CatalogImageBaseUrl"]
            ?? "https://b2b.naifjewellery.com/images/katalog/";
        _logger = logger;
    }

    [HttpGet("excel")]
    [HttpGet("~/api/products/catalog-export/excel")]
    public async Task<IActionResult> Excel(int customerId, [FromQuery] string lang, CancellationToken cancellationToken)
    {
        var catalog = customerId > 0
            ? await BuildCatalog(customerId, cancellationToken)
            : await BuildGeneralCatalog(cancellationToken);
        if (catalog is null) return NotFound(new { message = "Müşteri bulunamadı." });

        var productImages = await LoadProductImages(catalog.Products, cancellationToken);
        Response.Headers["X-Catalog-Images-Loaded"] = productImages.Count.ToString();
        Response.Headers["X-Catalog-Images-Requested"] = catalog.Products.Count.ToString();
        using var workbook = new XLWorkbook();
        var english = IsEnglish(lang);
        AddCustomerProductsSheet(workbook, catalog, english, productImages);
        AddCustomerStonesSheet(workbook, catalog, english);
        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", FileName("xlsx"));
    }

    [HttpGet("pdf")]
    [HttpGet("~/api/products/catalog-export/pdf")]
    public async Task<IActionResult> Pdf(int customerId, [FromQuery] string lang, CancellationToken cancellationToken)
    {
        var catalog = customerId > 0
            ? await BuildCatalog(customerId, cancellationToken)
            : await BuildGeneralCatalog(cancellationToken);
        if (catalog is null) return NotFound(new { message = "Müşteri bulunamadı." });

        var productImages = await LoadProductImages(catalog.Products, cancellationToken);
        Response.Headers["X-Catalog-Images-Loaded"] = productImages.Count.ToString();
        Response.Headers["X-Catalog-Images-Requested"] = catalog.Products.Count.ToString();
        var english = IsEnglish(lang);
        QuestPDF.Settings.License = LicenseType.Community;
        var bytes = Document.Create(document =>
        {
            document.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(18);
                page.DefaultTextStyle(x => x.FontSize(9));
                page.Header().Column(column =>
                {
                    column.Item().Text(english
                        ? (catalog.IsCustomerSpecific ? "Customer-Specific Product Catalog" : "Product Catalog")
                        : (catalog.IsCustomerSpecific ? "Müşteriye Özel Ürün Kataloğu" : "Ürün Kataloğu")).FontSize(16).Bold();
                    column.Item().Text($"{DateTime.Now:dd.MM.yyyy}");
                });
                page.Content().PaddingTop(8).Column(column =>
                {
                    foreach (var row in catalog.Products)
                    {
                        column.Item().BorderBottom(1).BorderColor(QuestPDF.Helpers.Colors.Grey.Lighten2).PaddingVertical(7).Row(card =>
                        {
                            productImages.TryGetValue(row.Product.Id, out var image);
                            card.ConstantItem(86).Height(86).Border(1).BorderColor(QuestPDF.Helpers.Colors.Grey.Lighten3)
                                .AlignCenter().AlignMiddle().Element(container =>
                                {
                                    if (image is not null) container.Image(image).FitArea();
                                    else container.Text("Görsel yok").FontColor(QuestPDF.Helpers.Colors.Grey.Medium);
                                });
                            card.RelativeItem().PaddingLeft(10).Column(info =>
                            {
                                info.Item().Text(row.Product.Code ?? "").FontSize(13).Bold();
                                info.Item().Text($"{row.Total:0.00} $").FontSize(15).Bold().FontColor(QuestPDF.Helpers.Colors.Green.Medium);
                                info.Item().PaddingTop(5).Table(table =>
                                {
                                    table.ColumnsDefinition(columns => { columns.RelativeColumn(); columns.RelativeColumn(); columns.RelativeColumn(); columns.RelativeColumn(); });
                                    DetailCell(table, english ? "WEIGHT" : "AĞIRLIK", $"{row.Product.Gram:0.####} g");
                                    DetailCell(table, english ? "PURITY" : "AYAR", row.Product.MetalPurity?.Name ?? "-");
                                    DetailCell(table, english ? "CARAT" : "KARAT", $"{ProductCarat(row):0.####} ct");
                                    DetailCell(table, english ? "COLOR" : "RENK", ProductColor(row));
                                });
                                info.Item().PaddingTop(7).Text(english ? "Stone Details" : "Taş Bilgileri").Bold();
                                info.Item().PaddingTop(2).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(1.2f); columns.RelativeColumn(1.5f); columns.RelativeColumn(); columns.RelativeColumn(.7f); columns.RelativeColumn();
                                    });
                                    var headers = english
                                        ? new[] { "Clarity", "Stone Type", "Color", "Qty", "Total Ct." }
                                        : new[] { "Berraklık", "Taş Türü", "Renk", "Adet", "Toplam Kr." };
                                    foreach (var header in headers)
                                        table.Cell().Background(QuestPDF.Helpers.Colors.Grey.Lighten3).Padding(2).Text(header).FontSize(7).Bold();
                                    foreach (var stone in row.Stones)
                                    {
                                        StoneCell(table, stone.Clarity); StoneCell(table, stone.Type); StoneCell(table, stone.Color);
                                        StoneCell(table, stone.Quantity.ToString("0.####")); StoneCell(table, $"{stone.TotalCarat:0.####} ct", true);
                                    }
                                    if (row.Stones.Count == 0)
                                        table.Cell().ColumnSpan(5).Padding(2).Text(english ? "No stone details" : "Taş bilgisi yok").FontSize(7).FontColor(QuestPDF.Helpers.Colors.Grey.Medium);
                                });
                            });
                        });
                    }
                });
                page.Footer().AlignCenter().Text(text => { text.Span("Sayfa "); text.CurrentPageNumber(); text.Span(" / "); text.TotalPages(); });
            });
        }).GeneratePdf();
        return File(bytes, "application/pdf", FileName("pdf"));
    }

    private async Task<Catalog?> BuildCatalog(int customerId, CancellationToken ct)
    {
        var customer = await _unitOfWork.GetReadRepository<Users>().GetAsync(x => x.Id == customerId && !x.IsDeleted,
            include: q => q.Include(x => x.PricingProfile).Include(x => x.CustomStonePrices)
                .Include(x => x.CustomPolishingCosts).Include(x => x.UserSettingPrices));
        if (customer is null) return null;

        var products = await LoadProducts(ct);
        var multiplier = customer.PricingProfile?.SalesMultiplier is > 0 ? customer.PricingProfile.SalesMultiplier.Value : 1m;
        var rows = products.Select(p => Price(p, customer, multiplier)).ToList();
        return new Catalog(customer, customer.PricingProfile, multiplier, rows, true);
    }

    private async Task<Catalog> BuildGeneralCatalog(CancellationToken ct)
    {
        var customer = new Users
        {
            FirstName = "Genel", LastName = "Katalog", CompanyName = "Ürünler",
            CustomStonePrices = new List<UserStonePrice>(), CustomPolishingCosts = new List<UserPolishingCost>(),
            UserSettingPrices = new List<UserSettingPrice>()
        };
        var products = await LoadProducts(ct);
        return new Catalog(customer, null, 1m, products.Select(p => Price(p, customer, 1m)).ToList(), false);
    }

    private async Task<List<Products>> LoadProducts(CancellationToken ct)
    {
        var query = await _unitOfWork.GetReadRepository<Products>().GetAllQueryAsync(x => !x.IsDeleted,
            include: q => q.Include(x => x.Categories).Include(x => x.MetalPurity).Include(x => x.MetalColor)
                .Include(x => x.StoneColor).Include(x => x.Currency).Include(x => x.Images)
                .Include(x => x.ProductMetals).ThenInclude(x => x.MetalType)
                .Include(x => x.ProductMetals).ThenInclude(x => x.MetalPurity)
                .Include(x => x.ProductMetals).ThenInclude(x => x.Colors)
                .Include(x => x.ProductStones).ThenInclude(x => x.Clarity)
                .Include(x => x.ProductStones).ThenInclude(x => x.Color)
                .Include(x => x.ProductStones).ThenInclude(x => x.Stone).ThenInclude(x => x.StoneScale)
                .Include(x => x.ProductStones).ThenInclude(x => x.Stone).ThenInclude(x => x.StoneType)
                .Include(x => x.ProductStones).ThenInclude(x => x.Stone).ThenInclude(x => x.StoneCut)
                .Include(x => x.ProductStones).ThenInclude(x => x.Stone).ThenInclude(x => x.StoneSetting).ThenInclude(x => x.Unit),
            cancellationToken: ct);
        return await query.OrderBy(x => x.Code).ToListAsync(ct);
    }

    private static ProductRow Price(Products p, Users customer, decimal multiplier)
    {
        var milyem = p.MetalPurity?.Milyem is > 0 ? p.MetalPurity.Milyem : .585m;
        var goldPrice = p.LiveGoldPrice > 0 ? p.LiveGoldPrice : 150m;
        var laborMultiplier = customer.PricingProfile?.CustomMilyem ?? p.LaborMultiplier;
        var gold = p.Gram * milyem * goldPrice;
        var labor = p.Gram * laborMultiplier * goldPrice;
        var stones = new List<StoneRow>();
        foreach (var ps in p.ProductStones.Where(x => !x.IsDeleted && x.Stone != null))
        {
            var s = ps.Stone!;
            var customStone = customer.CustomStonePrices?.FirstOrDefault(x => !x.IsDeleted && x.StoneId == s.Id);
            var unitPrice = customStone?.CustomPrice is > 0 ? customStone.CustomPrice.Value : s.CostPrice;
            var customSetting = s.StoneSettingId.HasValue
                ? customer.UserSettingPrices?.FirstOrDefault(x => !x.IsDeleted && x.StoneSettingId == s.StoneSettingId.Value)
                : null;
            var settingPrice = customSetting?.CustomPrice is > 0 ? customSetting.CustomPrice.Value
                : customStone?.CustomSettingPrice is > 0 ? customStone.CustomSettingPrice.Value
                : s.StoneSetting?.SettingPrice ?? 0;
            var unit = s.StoneSetting?.Unit?.Name ?? "";
            var settingCost = unit.Contains("adet", StringComparison.OrdinalIgnoreCase) || unit.Equals("piece", StringComparison.OrdinalIgnoreCase)
                ? ps.Quantity * settingPrice : ps.TotalCarat * settingPrice;
            stones.Add(new StoneRow(s.StoneScale?.Name ?? $"Taş #{s.Id}", s.StoneType?.Name ?? "", s.StoneCut?.Name ?? "", ps.Clarity?.Name ?? s.StoneClarity?.Name ?? "", ps.Color?.Name ?? s.Colors?.Name ?? "", ps.Quantity, ps.Carat, ps.TotalCarat, unitPrice, ps.TotalCarat * unitPrice, unit, settingPrice, settingCost));
        }
        var polishing = customer.CustomPolishingCosts?.FirstOrDefault(x => !x.IsDeleted && x.CategoryId.HasValue && p.Categories.Any(c => c.Id == x.CategoryId))
            ?? customer.CustomPolishingCosts?.FirstOrDefault(x => !x.IsDeleted && x.CategoryId == null);
        var polish = polishing?.CustomPrice is > 0 ? polishing.CustomPrice : p.PolishingCost;
        var subtotal = gold + labor + stones.Sum(x => x.Cost) + stones.Sum(x => x.SettingCost) + polish;
        return new ProductRow(p, milyem, laborMultiplier, gold, labor, stones.Sum(x => x.Cost), stones.Sum(x => x.SettingCost), polish, subtotal, subtotal * multiplier, stones);
    }

    private void AddCustomerProductsSheet(XLWorkbook book, Catalog catalog, bool english,
        IReadOnlyDictionary<int, byte[]> productImages)
    {
        var ws = book.Worksheets.Add(english ? "Products" : "Ürünler");
        var headers = english
            ? new[] { "Image", "Product Code", "Category", "Weight (g)", "Purity", "Total Carat", "Color", "Total Price ($)" }
            : new[] { "Resim", "Ürün Kodu", "Kategori", "Ağırlık (g)", "Ayar", "Toplam Karat", "Renk", "Toplam Fiyat ($)" };
        WriteHeader(ws, headers);
        var r = 2;
        foreach (var x in catalog.Products)
        {
            object?[] values = { "", x.Product.Code, Join(x.Product.Categories.Select(c => c.Name)), x.Product.Gram, x.Product.MetalPurity?.Name, ProductCarat(x), ProductColor(x), x.Total };
            for (var c = 0; c < values.Length; c++) ws.Cell(r, c + 1).Value = XLCellValue.FromObject(values[c]);
            if (productImages.TryGetValue(x.Product.Id, out var image))
                ws.AddPicture(new MemoryStream(image)).MoveTo(ws.Cell(r, 1), 4, 4).WithSize(72, 72);
            ws.Row(r).Height = 58;
            r++;
        }
        ws.Column(1).Width = 13;
        ws.Column(8).Style.NumberFormat.Format = "#,##0.00";
        Finish(ws);
    }

    private static void AddCustomerStonesSheet(XLWorkbook book, Catalog catalog, bool english)
    {
        var ws = book.Worksheets.Add(english ? "Stone Details" : "Taş Bilgileri");
        WriteHeader(ws, english
            ? new[] { "Product Code", "Clarity", "Stone Type", "Color", "Quantity", "Unit Carat", "Total Carat" }
            : new[] { "Ürün Kodu", "Berraklık", "Taş Türü", "Renk", "Adet", "Birim Karat", "Toplam Karat" });
        var r = 2;
        foreach (var product in catalog.Products)
        foreach (var stone in product.Stones)
        {
            object?[] values = { product.Product.Code, stone.Clarity, stone.Type, stone.Color, stone.Quantity, stone.Carat, stone.TotalCarat };
            for (var c = 0; c < values.Length; c++) ws.Cell(r, c + 1).Value = XLCellValue.FromObject(values[c]);
            r++;
        }
        Finish(ws);
    }

    private static void AddStonesSheet(XLWorkbook book, Catalog catalog)
    {
        var ws = book.Worksheets.Add("Taş Detayları");
        WriteHeader(ws, new[] { "Ürün Kodu", "Taş", "Tip", "Kesim", "Berraklık", "Renk", "Adet", "Adet Karat", "Toplam Karat", "Özel/Birim Taş Fiyatı", "Taş Tutarı", "Mıhlama Birimi", "Özel/Birim Mıhlama Fiyatı", "Mıhlama Tutarı" });
        var r = 2;
        foreach (var p in catalog.Products) foreach (var s in p.Stones)
        {
            object?[] values = { p.Product.Code, s.Name, s.Type, s.Cut, s.Clarity, s.Color, s.Quantity, s.Carat, s.TotalCarat, s.UnitPrice, s.Cost, s.SettingUnit, s.SettingPrice, s.SettingCost };
            for (var c = 0; c < values.Length; c++) ws.Cell(r, c + 1).Value = XLCellValue.FromObject(values[c]);
            r++;
        }
        Finish(ws);
    }

    private static void AddMetalsSheet(XLWorkbook book, Catalog catalog)
    {
        var ws = book.Worksheets.Add("Maden Detayları");
        WriteHeader(ws, new[] { "Ürün Kodu", "Maden Tipi", "Ayar", "Milyem", "Yoğunluk", "Renk", "Gram" });
        var r = 2;
        foreach (var p in catalog.Products) foreach (var m in p.Product.ProductMetals.Where(x => !x.IsDeleted))
        {
            object?[] values = { p.Product.Code, m.MetalType?.Name, m.MetalPurity?.Name, m.MetalPurity?.Milyem, m.MetalPurity?.Density, m.Colors?.Name, m.Weight };
            for (var c = 0; c < values.Length; c++) ws.Cell(r, c + 1).Value = XLCellValue.FromObject(values[c]);
            r++;
        }
        Finish(ws);
    }

    private static void AddPricingSheet(XLWorkbook book, Catalog c)
    {
        var ws = book.Worksheets.Add("Müşteri Fiyatlandırması");
        ws.Cell("A1").Value = "Müşteri"; ws.Cell("B1").Value = CustomerName(c.Customer);
        ws.Cell("A2").Value = "Firma"; ws.Cell("B2").Value = c.Customer.CompanyName;
        ws.Cell("A3").Value = "Özel İşçilik/Milyem"; ws.Cell("B3").Value = c.Profile?.CustomMilyem?.ToString("0.####") ?? "Ürün bazlı";
        ws.Cell("A4").Value = "Satış Çarpanı"; ws.Cell("B4").Value = c.Multiplier;
        ws.Cell("A6").Value = "Özel taş fiyatları, özel mıhlama fiyatları ve kategori/genel cila fiyatları ilgili ürün satırlarına uygulanmıştır.";
        ws.Range("A6:F6").Merge(); Finish(ws);
    }

    private static void WriteHeader(IXLWorksheet ws, string[] headers)
    {
        for (var i = 0; i < headers.Length; i++) ws.Cell(1, i + 1).Value = headers[i];
        ws.Range(1, 1, 1, headers.Length).Style.Font.Bold = true;
        ws.Range(1, 1, 1, headers.Length).Style.Fill.BackgroundColor = XLColor.FromHtml("#3B82F6");
        ws.Range(1, 1, 1, headers.Length).Style.Font.FontColor = XLColor.White;
        ws.SheetView.FreezeRows(1); ws.RangeUsed()?.SetAutoFilter();
    }

    private static void Finish(IXLWorksheet ws) { ws.ColumnsUsed().AdjustToContents(5, 45); ws.RowsUsed().Style.Alignment.Vertical = XLAlignmentVerticalValues.Top; }
    private static string Join(IEnumerable<string?> values) => string.Join(", ", values.Where(x => !string.IsNullOrWhiteSpace(x)));
    private static bool IsEnglish(string? lang) => string.Equals(lang, "en", StringComparison.OrdinalIgnoreCase);
    private static decimal ProductCarat(ProductRow row) => row.Stones.Count > 0 ? row.Stones.Sum(x => x.TotalCarat) : row.Product.DiamondCarat;
    private static string StoneNames(ProductRow row) => Join(row.Stones.Select(x => x.Name).Distinct());
    private static string StoneColors(ProductRow row)
    {
        var colors = row.Stones.Select(x => x.Color).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().ToList();
        if (colors.Count == 0 && !string.IsNullOrWhiteSpace(row.Product.StoneColor?.Name)) colors.Add(row.Product.StoneColor.Name);
        return Join(colors);
    }
    private static string ProductColor(ProductRow row) => !string.IsNullOrWhiteSpace(row.Product.MetalColor?.Name)
        ? row.Product.MetalColor.Name : StoneColors(row);
    private static void DetailCell(TableDescriptor table, string label, string value) => table.Cell().Padding(2).Column(column =>
    {
        column.Item().Text(label).FontSize(6).FontColor(QuestPDF.Helpers.Colors.Grey.Medium);
        column.Item().Text(value).FontSize(8).Bold();
    });
    private static void StoneCell(TableDescriptor table, string value, bool accent = false)
    {
        var text = table.Cell().BorderBottom(1).BorderColor(QuestPDF.Helpers.Colors.Grey.Lighten3).Padding(2).Text(value ?? "-").FontSize(7);
        if (accent) text.FontColor(QuestPDF.Helpers.Colors.Blue.Medium).Bold();
    }
    private async Task<IReadOnlyDictionary<int, byte[]>> LoadProductImages(IEnumerable<ProductRow> rows, CancellationToken ct)
    {
        var tasks = rows.Select(async row => (row.Product.Id, Image: await ReadPrimaryImage(row.Product, ct)));
        var images = await Task.WhenAll(tasks);
        return images.Where(x => x.Image is not null).ToDictionary(x => x.Id, x => x.Image!);
    }

    private async Task<byte[]?> ReadPrimaryImage(Products product, CancellationToken ct)
    {
        foreach (var imageName in ImageNames(product))
        {
            // NormalizeImagePath returns a forward-slash relative path (e.g. "KATEGORI/URUN_1.jpg")
            var relative = NormalizeImagePath(imageName);
            if (string.IsNullOrWhiteSpace(relative)) continue;

            // Canlı API sunucusunda görselin birebir kopyası varsa doğrudan oku.
            // Burada ürün koduyla arama/fallback yapılmaz; yalnızca DB'deki tam yol
            // eşleştiği için eski veya başka bir ürünün resmi seçilemez.
            var osRelative = relative.Replace('/', Path.DirectorySeparatorChar);
            var exactLocalPath = new[]
            {
                Path.Combine(_environment.WebRootPath, "images", "katalog", osRelative),
                Path.Combine(_environment.WebRootPath, "images", osRelative),
                Path.Combine(_environment.WebRootPath, osRelative)
            }.FirstOrDefault(System.IO.File.Exists);
            if (exactLocalPath is not null)
                return await System.IO.File.ReadAllBytesAsync(exactLocalPath, ct);

            // Build URL by appending each segment individually to avoid double-encoding issues
            // relative uses '/' as separator regardless of OS
            var baseUri = _catalogImageBaseUrl.TrimEnd('/');
            // Try without encoding first (most web servers handle UTF-8 paths natively)
            var rawUrl = baseUri + "/" + relative.Replace('\\', '/');
            // Also try with percent-encoded segments as fallback
            var encodedSegments = string.Join('/',
                relative.Replace('\\', '/').Split('/', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Uri.EscapeDataString));
            var encodedUrl = baseUri + "/" + encodedSegments;

            foreach (var url in new[] { rawUrl, encodedUrl })
            {
                if (!Uri.TryCreate(url, UriKind.Absolute, out var uri)) continue;
                var gateEntered = false;
                try
                {
                    await ImageDownloadGate.WaitAsync(ct);
                    gateEntered = true;
                    using var response = await ImageClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead, ct);
                    if (response.IsSuccessStatusCode && response.Content.Headers.ContentType?.MediaType?.StartsWith("image/") == true)
                        return await response.Content.ReadAsByteArrayAsync(ct);
                    _logger.LogWarning("Katalog görseli indirilemedi. Url: {Url}, Status: {Status}, ContentType: {ContentType}",
                        uri, (int)response.StatusCode, response.Content.Headers.ContentType?.MediaType);
                }
                catch (HttpRequestException ex)
                {
                    _logger.LogWarning(ex, "Katalog görseli HTTP hatası. Url: {Url}", uri);
                }
                finally { if (gateEntered) ImageDownloadGate.Release(); }
            }
        }
        return null;
    }

    private static IEnumerable<string> ImageNames(Products product) =>
        product.Images.Where(x => !x.IsDeleted).OrderBy(x => x.SortOrder).Select(x => x.ImageName)
            // Products.ImageName yönetim ekranında seçilen güncel ana resimdir.
            // Eski ProductImage satırlarının PDF/Excel'de öne geçmesini engelle.
            .Prepend(product.ImageName).Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(x => x!).Distinct(StringComparer.OrdinalIgnoreCase);

    private string? PrimaryImagePath(Products product)
    {
        foreach (var imageName in ImageNames(product))
        {
            var relative = NormalizeImagePath(imageName!);
            if (string.IsNullOrWhiteSpace(relative)) continue;
            // Convert forward-slash relative path to OS path separator for file system access
            var osRelative = relative.Replace('/', Path.DirectorySeparatorChar);
            var direct = new[]
            {
                Path.Combine(_environment.WebRootPath, "images", "katalog", osRelative),
                Path.Combine(_environment.WebRootPath, "images", osRelative),
                Path.Combine(_environment.WebRootPath, osRelative)
            }.FirstOrDefault(System.IO.File.Exists);
            if (direct is not null) return direct;
        }

        // Eski kayıtlarda klasör ya da dosya adı yanlış olabiliyor. Ürün koduyla gerçek görseli bul.
        var catalogRoot = Path.Combine(_environment.WebRootPath, "images", "katalog");
        if (!Directory.Exists(catalogRoot) || string.IsNullOrWhiteSpace(product.Code)) return null;
        var code = product.Code.Trim();
        var matches = Directory.EnumerateFiles(catalogRoot, "*", SearchOption.AllDirectories)
            .Where(path => IsSupportedImage(path) && Path.GetFileNameWithoutExtension(path).StartsWith(code, StringComparison.OrdinalIgnoreCase))
            .ToList();
        return matches.FirstOrDefault(path => Path.GetFileNameWithoutExtension(path).Equals(code, StringComparison.OrdinalIgnoreCase))
            ?? matches.FirstOrDefault();
    }
    private static string? NormalizeImagePath(string imageName)
    {
        var value = imageName.Trim();
        if (Uri.TryCreate(value, UriKind.Absolute, out var uri))
            value = Uri.UnescapeDataString(uri.AbsolutePath);

        // Normalize to forward slashes for consistent processing
        value = value.Replace('\\', '/');
        const string catalogMarker = "/images/katalog/";
        var catalogIndex = value.IndexOf(catalogMarker, StringComparison.OrdinalIgnoreCase);
        if (catalogIndex >= 0)
            value = value[(catalogIndex + catalogMarker.Length)..];
        else
        {
            const string imagesMarker = "/images/";
            var imagesIndex = value.IndexOf(imagesMarker, StringComparison.OrdinalIgnoreCase);
            if (imagesIndex >= 0)
                value = value[(imagesIndex + imagesMarker.Length)..];
        }

        value = value.TrimStart('/');
        if (value.StartsWith("images/katalog/", StringComparison.OrdinalIgnoreCase))
            value = value["images/katalog/".Length..];
        else if (value.StartsWith("images/", StringComparison.OrdinalIgnoreCase))
            value = value["images/".Length..];

        // Keep forward slashes — callers convert to OS separator as needed for file system access
        // This ensures the path works correctly for both HTTP URLs and Path.Combine
        return value.Split('/').Any(part => part == "..") ? null : value;
    }
    private static bool IsSupportedImage(string path) => new[] { ".jpg", ".jpeg", ".png", ".webp" }.Contains(Path.GetExtension(path), StringComparer.OrdinalIgnoreCase);
    private static string CustomerName(Users u) => string.Join(" ", new[] { u.FirstName, u.LastName }.Where(x => !string.IsNullOrWhiteSpace(x)));
    private static string FileName(string extension) => $"katalog_{DateTime.Now:yyyyMMdd}.{extension}";

    private sealed record Catalog(Users Customer, UserPricingProfile? Profile, decimal Multiplier, List<ProductRow> Products, bool IsCustomerSpecific);
    private sealed record ProductRow(Products Product, decimal Milyem, decimal LaborMultiplier, decimal GoldCost, decimal LaborCost, decimal StoneCost, decimal SettingCost, decimal PolishingCost, decimal Subtotal, decimal Total, List<StoneRow> Stones) { public decimal FineGold => Product.Gram * Milyem; }
    private sealed record StoneRow(string Name, string Type, string Cut, string Clarity, string Color, decimal Quantity, decimal Carat, decimal TotalCarat, decimal UnitPrice, decimal Cost, string SettingUnit, decimal SettingPrice, decimal SettingCost);
}
