using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.GymOwners.Commands.Create
{
    public record GymOwnerCreateCommand(
        [Required] string Names,
        [Required] string Surnames,
        [Required] string Email,
        [Required] string CellPhone,
        [Required] GymCreateCommand Gym,
        [Required] UserCreateCommand User
    ) : IRequest;
    
    public record UserCreateCommand(
        [Required] string UserName,
        [Required] string Password
    );
    
    public record GymCreateCommand(
        [Required] string Name,
        [Required] string Address
    );

} 
