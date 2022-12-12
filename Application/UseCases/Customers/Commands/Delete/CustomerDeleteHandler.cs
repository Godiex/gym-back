using Application.UseCases.Customers.Commands.Create;
using AutoMapper;
using Domain.Entities;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Customers.Commands.Delete {

    public class CustomerDeleteHandler : AsyncRequestHandler<CustomerDeleteCommand>
    {
        private readonly CustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerDeleteHandler(CustomerService customerService, IMapper mapper)
        {
            _mapper = mapper;
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        protected override async Task Handle(CustomerDeleteCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            await _customerService.Delete(request.Id);
        }

    }
}