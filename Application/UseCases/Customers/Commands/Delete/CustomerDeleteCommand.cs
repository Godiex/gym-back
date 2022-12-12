using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.Customers.Commands.Delete
{
    public record CustomerDeleteCommand(
        [Required] Guid Id
    ) : IRequest;

} 
