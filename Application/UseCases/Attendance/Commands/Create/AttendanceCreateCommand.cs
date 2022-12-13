using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.Attendance.Commands.Create
{
    public record AttendanceCreateCommand(
        [Required] Guid UserId
    ) : IRequest;

} 
