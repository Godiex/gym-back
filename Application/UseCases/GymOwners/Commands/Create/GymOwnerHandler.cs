using AutoMapper;
using Domain.Entities;
using Domain.Services;
using MediatR;

namespace Application.UseCases.GymOwners.Commands.Create {

    public class GymOwnerHandler : AsyncRequestHandler<GymOwnerCreateCommand>
    {
        private readonly GymOwnerService _gymOwnerService;
        private readonly IMapper _mapper;

        public GymOwnerHandler(GymOwnerService gymOwnerService, IMapper mapper)
        {
            _mapper = mapper;
            _gymOwnerService = gymOwnerService ?? throw new ArgumentNullException(nameof(gymOwnerService));
        }

        protected override async Task Handle(GymOwnerCreateCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var gymOwner = _mapper.Map<GymOwner>(request);
            await _gymOwnerService.CreateGymOwnerAsync(gymOwner);
        }

    }
}