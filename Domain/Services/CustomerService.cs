using Domain.Entities;
using Domain.Enums;
using Domain.Exceptions;
using Domain.Ports;

namespace Domain.Services
{
    [DomainService]
    public class CustomerService
    {
        private readonly IGenericRepository<Customer> _repository;
        public CustomerService(IGenericRepository<Customer> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<Customer> Create(Customer customer)
        {
            var customerSearched = (await _repository.GetAsync(x => x.Identification == customer.Identification)).FirstOrDefault();
            if (customerSearched != null)
            {
                throw new AppException("Ya existe un cliente con este numero de documento");
            }
            await _repository.AddAsync(customer);
            return customer;
        }
        
        public async Task<Customer> Delete(Guid id)
        {
            var customerSearched = (await _repository.GetAsync(x => x.Id == id)).FirstOrDefault();
            if (customerSearched == null)
            {
                throw new AppException($"no existe un cliente con este id {id}");
            }
            await _repository.DeleteAsync(customerSearched);
            return customerSearched;
        }
        
        public async Task<Customer> Update(Customer customer)
        {
            await _repository.UpdateAsync(customer);
            return customer;
        }
        
        public async Task<List<Customer>> Get(Guid gymId)
        {
            var customersByGym = await _repository.GetAsync(x => x.GymId == gymId, includeObjectProperties: c => c.Plan);
            return customersByGym.ToList();
        }
        
        public async Task<Customer> GetByUserId(Guid userId)
        {
            var customerSearched = (await _repository.GetAsync(x => x.User.Id == userId, includeStringProperties:"User,Gym")).FirstOrDefault();
            if (customerSearched == null)
            {
                throw new AppException($"no existe un cliente con este id {userId}");
            }

            return customerSearched;
        }
        
        public async Task<Customer> GetById(Guid id)
        {
            var customerSearched = (await _repository.GetAsync(x => x.Id == id)).FirstOrDefault();
            if (customerSearched == null)
            {
                throw new AppException($"no existe un cliente con este id {id}");
            }

            return customerSearched;
        }
    }
}
