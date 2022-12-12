using AutoMapper;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Customers.Queries
{
    public class CustomerQueryHandler : IRequestHandler<CustomerQuery, List<CustomerDto>>
    {
        private readonly CustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerQueryHandler(CustomerService customerService, IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
            _mapper = mapper;
        }

        public async Task<List<CustomerDto>> Handle(CustomerQuery request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var customers = await _customerService.Get(request.GymId);     
            return _mapper.Map<List<CustomerDto>>(customers);
        }
    }
}