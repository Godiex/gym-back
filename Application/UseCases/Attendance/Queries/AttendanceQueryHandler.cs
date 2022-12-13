using AutoMapper;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Attendance.Queries
{
    public class AttendanceQueryHandler : IRequestHandler<AttendanceTodayQuery, AttendanceTodayDto>
    {
        private readonly AttendanceService _attendanceService;

        public AttendanceQueryHandler(AttendanceService attendanceService)
        {
            _attendanceService = attendanceService ?? throw new ArgumentNullException(nameof(attendanceService));
        }

        public async Task<AttendanceTodayDto> Handle(AttendanceTodayQuery request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var attendanceToday = await _attendanceService.GetIfAttendanceToday(request.UserId);
            return new AttendanceTodayDto(attendanceToday);
        }
    }
}