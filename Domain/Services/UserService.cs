using Domain.Entities;
using Domain.Exceptions;
using Domain.Ports;

namespace Domain.Services
{
    [DomainService]
    public class UserService
    {
        private readonly IGenericRepository<User> _repository;
        public UserService(IGenericRepository<User> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository), "No repo available");
        }

        public async Task<User> LogIn(string userName, string password)
        {
            var userSearched = (await _repository.GetAsync(x => x.UserName == userName && x.Password == password)).FirstOrDefault();
            if (userSearched == null)
            {
                throw new AppException("El usuario o la contraseña son incorrectos");
            }

            return userSearched;
        }
    }
}
