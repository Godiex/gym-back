using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.Customers.Commands.Update
{
    public record CustomerUpdateCommand(
        [Required] Guid Id,
        [Required] string Identification,
        [Required] string Names,
        [Required] string Surnames,
        [Required] string Email,
        [Required] string CellPhone,
        [Required] float Weight,
        [Required] float Tall,
        [Required] UserUpdateCustomerCommand User
    ) : IRequest;
    
    public record UserUpdateCustomerCommand(
        [Required] string UserName,
        [Required] string Password
    );

} 
