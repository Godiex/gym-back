using Application.UseCases.Customers.Queries;
using AutoMapper;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Plan.Queries
{
    public class PlanByCustomerQueryHandler : IRequestHandler<PlanByCustomerQuery, List<PlanByCustomerDto>>
    {
        private readonly CustomerService _customerService;
        private readonly IMapper _mapper;

        public PlanByCustomerQueryHandler(CustomerService customerService, IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
            _mapper = mapper;
        }

        public async Task<List<PlanByCustomerDto>> Handle(PlanByCustomerQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}