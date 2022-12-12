using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.Users.Commands.LogIn
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
