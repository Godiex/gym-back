using System.Text;

namespace Application.UseCases.Attendance.Queries.GetAttendanceByGym {
    public record AttendanceByGymDto
    {
        public DateTime EntryDate { get; set; }
        public CustomerAttendanceDto Customer { get; set; }
    }
    
    public record CustomerAttendanceDto
    {
        public string Names { get; set; } = default!;
        public string Surnames { get; set; } = default!;
    }
}