using MediatR;

namespace Application.UseCases.Attendance.Queries {
    public record AttendanceTodayQuery(Guid UserId) : IRequest<AttendanceTodayDto>;
    
}