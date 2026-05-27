using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.AuthFeature.Commands.Login
{
    public class LoginCommandRequest : IRequest<ResponseDto<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
