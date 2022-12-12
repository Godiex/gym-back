using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Customers.Commands.Create {

    public class CustomerCreateHandler : AsyncRequestHandler<CustomerCreateCommand>
    {
        private readonly CustomerService _customerService;
        private readonly PlanService _planService;
        private readonly GymService _gymService;
        private readonly IMapper _mapper;

        public CustomerCreateHandler(CustomerService customerService, PlanService planService, GymService gymService, IMapper mapper)
        {
            _mapper = mapper;
            _planService  = planService ?? throw new ArgumentNullException(nameof(planService));
            _gymService  = gymService ?? throw new ArgumentNullException(nameof(gymService));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        protected override async Task Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var plan = await _planService.GetPlan();
            var customer = _mapper.Map(request, new Customer(request.GymId, plan.Id));
            customer.User.TypeUser = TypeUser.Customer;
            await _customerService.Create(customer);
        }

    }
}