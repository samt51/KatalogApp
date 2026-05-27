using System;
namespace KatalogApp.Application.Features.UserActionLogFeature.Dtos
{
    public class UserActionLogDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ActionType { get; set; }
        public int? ProductId { get; set; }
        public string? Details { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
