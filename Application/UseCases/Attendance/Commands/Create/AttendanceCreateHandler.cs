
using AutoMapper;
using Domain.Exceptions;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Attendance.Commands.Create {

    public class AttendanceCreateHandler : AsyncRequestHandler<AttendanceCreateCommand>
    {
        private readonly AttendanceService _attendanceService;

        public AttendanceCreateHandler(AttendanceService attendanceService)
        {
            _attendanceService = attendanceService ?? throw new ArgumentNullException(nameof(attendanceService));
        }

        protected override async Task Handle(AttendanceCreateCommand request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var attendanceToday = await _attendanceService.GetIfAttendanceToday(request.UserId);
            if (attendanceToday)
            {
                throw new AppException("El usuario ya realizo su asistencia al gymnacio");
            }
            await _attendanceService.Create(request.UserId);
        }

    }
}