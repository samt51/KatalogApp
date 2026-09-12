using System.ComponentModel.DataAnnotations;
namespace KatalogApp.Api.Models;
public sealed class ConfirmOrderRequest
{
    public Guid RequestId { get; set; }
    [Required, StringLength(200)] public string CompanyName { get; set; } = "";
    [Required, StringLength(100)] public string FirstName { get; set; } = "";
    [Required, StringLength(100)] public string LastName { get; set; } = "";
    [Required, StringLength(40), RegularExpression(@"\+?[0-9\s().\-]{7,40}")] public string PhoneNumber { get; set; } = "";
    [Required, MinLength(1), MaxLength(200)] public List<ConfirmOrderItem> Items { get; set; } = new();
    [Required] public string PdfBase64 { get; set; } = "";
}
public sealed class ConfirmOrderItem
{
    public int? ProductId { get; set; }
    [Required, StringLength(100)] public string Code { get; set; } = "";
    [StringLength(300)] public string? ProductName { get; set; }
    [StringLength(200)] public string? Category { get; set; }
    [StringLength(100)] public string? Price { get; set; }
    [StringLength(100)] public string? Ayar { get; set; }
    [StringLength(100)] public string? Renk { get; set; }
    [StringLength(100)] public string? Gram { get; set; }
    [Range(1,999)] public int Quantity { get; set; } = 1;
    [StringLength(2000)] public string? Note { get; set; }
    [MaxLength(100)] public List<ConfirmOrderStone> Stones { get; set; } = new();
}
public sealed class ConfirmOrderStone
{
    [StringLength(100)] public string? Type { get; set; }
    [StringLength(100)] public string? Clarity { get; set; }
    [StringLength(100)] public string? Color { get; set; }
    [StringLength(100)] public string? Quantity { get; set; }
    [StringLength(100)] public string? TotalCarat { get; set; }
}
