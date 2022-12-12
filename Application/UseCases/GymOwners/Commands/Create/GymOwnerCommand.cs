using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.GymOwners.Commands.Create
{
    public record GymOwnerCreateCommand(
        [Required] string Identification,
        [Required] string Names,
        [Required] string Surnames,
        [Required] string Email,
        [Required] string CellPhone,
        [Required] UserGymOwnerCreateCommand User,
        [Required] GymOwnerCreateGymCommand Gym
    ) : IRequest;
    
    public record UserGymOwnerCreateCommand(
        [Required] string UserName,
        [Required] string Password
    );
    
    public record GymOwnerCreateGymCommand(
        [Required] string Name,
        [Required] string Address
    );

} 
