using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Services;
using MediatR;

namespace Application.Users.Commands.LogIn {

    public class LogInUserHandler : IRequestHandler<LogInUserCommand, LogInUserDto>
    {
        private readonly UserService _userService;

        public LogInUserHandler(UserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public async Task<LogInUserDto> Handle(LogInUserCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var user = await _userService.LogIn(request.UserName, request.Password);
            return new LogInUserDto(user.Id, user.TypeUser == TypeUser.Admin ? "Admin" : "Customer" );
        }

    }
}