using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Helpers;
using KatalogApp.Domain.Entities;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.AuthFeature.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, ResponseDto<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<string>> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            var readRepo = _unitOfWork.GetReadRepository<Users>();
            var user = await readRepo.GetAsync(u => u.Email == request.Email && u.Password == PasswordHash.HashPassword(request.Password));

            if (user == null)
            {
                return new ResponseDto<string>().Fail("E-Posta veya Şifre hatalı.");
            }

            if (user.IsLocked)
            {
                return new ResponseDto<string>().Fail("Hesabınız kilitlenmiştir.");
            }

            // Generate JWT
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("KatalogAppSecretKeyForJwtAuthentication1234567890!"); // Should come from config in prod
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
                    new Claim(ClaimTypes.Role, user.RoleId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return new ResponseDto<string>().Success(tokenString);
        }
    }
}
