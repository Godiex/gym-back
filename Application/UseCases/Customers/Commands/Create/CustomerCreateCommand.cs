using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.Customers.Commands.Create
{
    public record CustomerCreateCommand(
        [Required] Guid GymId,
        [Required] string Identification,
        [Required] string Names,
        [Required] string Surnames,
        [Required] string Email,
        [Required] string CellPhone,
        [Required] float Weight,
        [Required] float Tall,
        [Required] UserCreateCustomerCommand User
    ) : IRequest;
    
    public record UserCreateCustomerCommand(
        [Required] string UserName,
        [Required] string Password
    );

} 
