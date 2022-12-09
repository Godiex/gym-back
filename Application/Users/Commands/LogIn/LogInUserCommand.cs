using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using MediatR;

namespace Application.Users.Commands.LogIn
{
    public record LogInUserCommand(
        [Required] string UserName,
        [Required] string Password
    ) : IRequest<LogInUserDto>;

    public record LogInUserDto(
        Guid UserId,
        string TypeUser
    );
} 
