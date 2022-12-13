using MediatR;

namespace Application.UseCases.Attendance.Queries.GetAttendanceByGym {
    public record AttendanceByGymQuery(Guid GymId) : IRequest<List<AttendanceByGymDto>>;
    
}