using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.UseCases.GymOwners.Queries {
    public record GymOwnerQuery([Required] Guid UserId) : IRequest<GymOwnerDto>;
    
}