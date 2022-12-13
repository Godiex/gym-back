using Domain.Entities;
using Domain.Enums;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Users.Commands.LogIn {

    public class LogInUserHandler : IRequestHandler<LogInUserCommand, LogInUserDto>
    {
        private readonly UserService _userService;
        private readonly GymOwnerService _gymOwnerService;
        private readonly CustomerService _customerService;

        public LogInUserHandler(UserService userService, GymOwnerService gymOwnerService, CustomerService customerService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _gymOwnerService = gymOwnerService ?? throw new ArgumentNullException(nameof(gymOwnerService));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        public async Task<LogInUserDto> Handle(LogInUserCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var user = await _userService.LogIn(request.UserName, request.Password);
            var gymId = user.TypeUser == TypeUser.Admin ? (await _gymOwnerService.Get(user.Id)).Gym.Id : (await _customerService.GetByUserId(user.Id)).Gym.Id;
            return new LogInUserDto(user.Id, gymId,user.TypeUser == TypeUser.Admin ? "Admin" : "Customer" );
        }

    }
}