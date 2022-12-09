using AutoMapper;
using Domain.Services;
using MediatR;

namespace Application.GymOwners.Queries
{
    public class GymOwnerQueryHandler : IRequestHandler<GymOwnerQuery, GymOwnerDto>
    {

        private readonly GymOwnerService _gymOwnerService;
        private readonly IMapper _mapper;

        public GymOwnerQueryHandler(GymOwnerService gymOwnerService, IMapper mapper)
        {
            _gymOwnerService = gymOwnerService ?? throw new ArgumentNullException(nameof(gymOwnerService));
            _mapper = mapper;
        }

        public async Task<GymOwnerDto> Handle(GymOwnerQuery request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var gymOwnerInfo = await _gymOwnerService.Get(request.UserId);     
            return _mapper.Map<GymOwnerDto>(gymOwnerInfo);
        }

        
    }
}