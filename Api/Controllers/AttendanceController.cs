using Application.UseCases.Attendance.Commands.Create;
using Application.UseCases.Attendance.Queries;
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

    [HttpPost]
    public async Task Post(AttendanceCreateCommand command) => await _mediator.Send(command);
    
}
