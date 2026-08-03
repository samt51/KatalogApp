using MediatR;
namespace KatalogApp.Application.Features.UserActionLogFeature.Commands.Create
{
    public class CreateUserActionLogCommandRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<bool>>
    {
        public int UserId { get; set; }
        public string ActionType { get; set; }
        public int? ProductId { get; set; }
        public string? Details { get; set; }
        public int? Quantity { get; set; }
        public string? Note { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
    }
}
