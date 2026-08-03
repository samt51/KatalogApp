using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Helpers;
using KatalogApp.Domain.Entities;
using MediatR;

namespace KatalogApp.Application.Features.UsersFeature.Commands.ChangePassword;

public sealed class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommandRequest, ResponseDto<bool>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ChangePasswordCommandHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    public async Task<ResponseDto<bool>> Handle(ChangePasswordCommandRequest request, CancellationToken cancellationToken)
    {
        var response = new ResponseDto<bool>();
        if (request.UserId <= 0 || string.IsNullOrWhiteSpace(request.CurrentPassword) ||
            string.IsNullOrWhiteSpace(request.NewPassword) || request.NewPassword.Length < 6)
            return response.Fail("Şifre en az 6 karakter olmalıdır.");

        var user = await _unitOfWork.GetReadRepository<Users>()
            .GetAsync(x => x.Id == request.UserId && !x.IsDeleted, enableTracking: true);

        if (user == null || !PasswordHash.VerifyPassword(request.CurrentPassword, user.Password))
            return response.Fail("Mevcut şifre hatalı.");

        if (PasswordHash.VerifyPassword(request.NewPassword, user.Password))
            return response.Fail("Yeni şifre mevcut şifreyle aynı olamaz.");

        user.Password = PasswordHash.HashPassword(request.NewPassword);
        await _unitOfWork.GetWriteRepository<Users>().UpdateAsync(user, cancellationToken);
        await _unitOfWork.SaveAsync(cancellationToken);
        return response.Success(true);
    }
}
