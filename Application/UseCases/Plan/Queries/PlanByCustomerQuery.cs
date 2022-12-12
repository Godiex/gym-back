using Application.UseCases.Customers.Queries;
using MediatR;

namespace Application.UseCases.Plan.Queries {
    public record PlanByCustomerQuery(Guid UserId) : IRequest<List<PlanByCustomerDto>>;
    
}