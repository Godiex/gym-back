using AutoMapper;
using Domain.Services;
using MediatR;

namespace Application.UseCases.Attendance.Queries.GetAttendanceByGym
{
    public class GetAttendanceByGymQueryHandler : IRequestHandler<AttendanceByGymQuery, List<AttendanceByGymDto>>
    {
        private readonly AttendanceService _attendanceService;
        private readonly IMapper _mapper;

        public GetAttendanceByGymQueryHandler(AttendanceService attendanceService, IMapper mapper)
        {
            _mapper = mapper;
            _attendanceService = attendanceService ?? throw new ArgumentNullException(nameof(attendanceService));
        }

        public async Task<List<AttendanceByGymDto>> Handle(AttendanceByGymQuery request, CancellationToken cancellationToken)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request), "request object needed to handle this task");
            var attendancesToday = await _attendanceService.GetAttendanceByGym(request.GymId);
            return _mapper.Map<List<AttendanceByGymDto>>(attendancesToday);
        }
    }
}