using Domain.Entities;
using Domain.Exceptions;
using Domain.Ports;

namespace Domain.Services
{
    [DomainService]
    public class PlanService
    {
        private readonly IGenericRepository<Plan> _repository;
        public PlanService(IGenericRepository<Plan> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Plan> GetPlan()
        {
            var planSearched = (await _repository.GetAsync()).FirstOrDefault();
            if (planSearched == null)
            {
                throw new AppException("No existe ningun plan registrado");
            }

            return planSearched;
        }
    }
}
