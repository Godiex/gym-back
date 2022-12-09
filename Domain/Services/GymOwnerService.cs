using Domain.Entities;
using Domain.Ports;

namespace Domain.Services
{
    [DomainService]
    public class GymOwnerService
    {
        private readonly IGenericRepository<GymOwner> _gymOwnerRepository;
        
        public GymOwnerService(IGenericRepository<GymOwner> gymOwnerRepository)
        {
            _gymOwnerRepository = gymOwnerRepository ?? throw new ArgumentNullException(nameof(gymOwnerRepository), "No repo available");
        }

        public async Task<GymOwner> CreateGymOwnerAsync(GymOwner gymOwner)
        {
           await _gymOwnerRepository.AddAsync(gymOwner);
           return gymOwner;
        }

        public async Task<GymOwner> Get(Guid userId)
        {
            return (await _gymOwnerRepository.GetAsync(x => x.UserId == userId, includeObjectProperties: owner => owner.Gym.Customers)).ToList().First();
        }

    }
}
