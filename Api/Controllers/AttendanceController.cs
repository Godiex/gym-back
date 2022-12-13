using Application.UseCases.Attendance.Commands.Create;
using Application.UseCases.Attendance.Queries;
using Application.UseCases.Attendance.Queries.GetAttendanceByGym;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AttendanceController
{
    private readonly IMediator _mediator;
    
    public AttendanceController(IMediator mediator) => _mediator = mediator;

    [HttpGet("{userId:guid}/today")]
    public async Task<AttendanceTodayDto> Get(Guid userId) => await _mediator.Send(new AttendanceTodayQuery(userId));
    
    [HttpGet("{gymId:guid}/gym")]
    public async Task<List<AttendanceByGymDto>> GetByGym(Guid gymId) => await _mediator.Send(new AttendanceByGymQuery(gymId));

    [HttpPost]
    public async Task Post(AttendanceCreateCommand command) => await _mediator.Send(command);
    
}
