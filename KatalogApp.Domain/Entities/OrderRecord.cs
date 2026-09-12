using System.ComponentModel.DataAnnotations;
namespace KatalogApp.Domain.Entities;
public class OrderRecord
{
    public Guid Id { get; set; }
    public Guid RequestId { get; set; }
    [MaxLength(50)] public string OrderNumber { get; set; } = "";
    public DateTime CreatedUtc { get; set; }
    public int AccountId { get; set; }
    [MaxLength(200)] public string AccountName { get; set; } = "";
    [MaxLength(254)] public string AccountEmail { get; set; } = "";
    [MaxLength(200)] public string AccountCompany { get; set; } = "";
    [MaxLength(200)] public string CompanyName { get; set; } = "";
    [MaxLength(100)] public string FirstName { get; set; } = "";
    [MaxLength(100)] public string LastName { get; set; } = "";
    [MaxLength(40)] public string PhoneNumber { get; set; } = "";
    [MaxLength(64)] public string RequestHash { get; set; } = "";
    [MaxLength(20)] public string EmailStatus { get; set; } = "Pending";
    public DateTime? EmailAttemptUtc { get; set; }
    public DateTime? EmailSentUtc { get; set; }
    public List<OrderLine> Items { get; set; } = new();
    public OrderDocument Document { get; set; } = null!;
}
public class OrderLine
{
    public int Id { get; set; }
    public Guid OrderId { get; set; }
    public int ProductId { get; set; }
    [MaxLength(100)] public string Code { get; set; } = "";
    [MaxLength(300)] public string ProductName { get; set; } = "";
    [MaxLength(200)] public string Category { get; set; } = "";
    [MaxLength(100)] public string Price { get; set; } = "";
    [MaxLength(100)] public string Ayar { get; set; } = "";
    [MaxLength(100)] public string Renk { get; set; } = "";
    [MaxLength(100)] public string Gram { get; set; } = "";
    public int Quantity { get; set; }
    [MaxLength(2000)] public string Note { get; set; } = "";
    public string StonesJson { get; set; } = "[]";
}
public class OrderDocument
{
    public Guid OrderId { get; set; }
    public byte[] Content { get; set; } = Array.Empty<byte>();
}
