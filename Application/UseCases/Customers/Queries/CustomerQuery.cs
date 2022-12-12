using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.Customers.Queries {
    public record CustomerQuery(Guid GymId) : IRequest<List<CustomerDto>>;
    
}