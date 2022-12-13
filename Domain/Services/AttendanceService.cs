using Domain.Entities;
using Domain.Enums;
using Domain.Exceptions;
using Domain.Ports;

namespace Domain.Services
{
    [DomainService]
    public class AttendanceService
    {
        private readonly IGenericRepository<Attendance> _repository;
        private readonly CustomerService _customerService;
        
        public AttendanceService(IGenericRepository<Attendance> repository, CustomerService customerService)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService), "No service available");
        }

        public async Task<Attendance> Create(Guid userId)
        {
            var customer = await _customerService.GetByUserId(userId);
            var attendance = new Attendance(customer.Id);
            await _repository.AddAsync(attendance);
            return attendance;
        }
        
        
        public async Task<bool> GetIfAttendanceToday(Guid userId)
        {
            var currentDate = DateTime.Now;
            var attendance = (await _repository.GetAsync(x => 
                x.Customer.User.Id == userId && x.EntryDate.Year == currentDate.Year &&
                x.EntryDate.Month == currentDate.Month && x.EntryDate.DayOfYear == currentDate.DayOfYear, includeStringProperties: "Customer.User")).FirstOrDefault();
            
            return attendance != null;
        }
    }
}
