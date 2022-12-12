using AutoMapper;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Customers.Commands.Update {

    public class CustomerUpdateHandler : AsyncRequestHandler<CustomerUpdateCommand>
    {
        private readonly CustomerService _customerService;
        private readonly PlanService _planService;
        private readonly IMapper _mapper;

        public CustomerUpdateHandler(CustomerService customerService, PlanService planService, IMapper mapper)
        {
            _mapper = mapper;
            _planService  = planService ?? throw new ArgumentNullException(nameof(planService));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        protected override async Task Handle(CustomerUpdateCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var customerSearched = await _customerService.GetById(request.Id);
            var customer = _mapper.Map(request, customerSearched);
            await _customerService.Update(customer);
        }

    }
}