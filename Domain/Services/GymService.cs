using Domain.Entities;
using Domain.Exceptions;
using Domain.Ports;

namespace Domain.Services
{
    [DomainService]
    public class GymService
    {
        private readonly IGenericRepository<Gym> _repository;
        public GymService(IGenericRepository<Gym> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Gym> GetGym(Guid id)
        {
            var gymSearched = (await _repository.GetAsync( x => x.Id == id)).FirstOrDefault();
            if (gymSearched == null)
            {
                throw new AppException("No existe ningun Gym registrado");
            }

            return gymSearched;
        }
    }
}
