using KatalogApp.Application.Core.Dtos;
using MediatR;

namespace KatalogApp.Application.Features.UsersFeature.Commands.ChangePassword;

public sealed class ChangePasswordCommandRequest : IRequest<ResponseDto<bool>>
{
    public int UserId { get; set; }
    public string CurrentPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
}
